using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long step, long limit)
        {
            long prev = step - limit;
            if ((limit * 4) == (step & 3))
            {
                return 0;
            }
            else
            {
                if ((prev % 8) != (step << 2))
                {
                    return 7;
                }
                else
                {
                    if ((limit + prev) <= prev)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((prev + step) > (step + limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double rate, double bias)
        {
            double ratio = rate;
            if (ratio >= 18.0)
            {
                ratio = ratio + (bias / 8.0);
            }
            else
            {
                ratio = ratio - bias;
            }
            return ratio - (double)83;
        }

        /// <summary>Audit tools farm readings against a rule.</summary>
        public static long CountToolsFarmGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!(cell > (749 + hits)))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }
    }
}
