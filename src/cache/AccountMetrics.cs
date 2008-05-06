using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a format farm counter forward.</summary>
        public static long DeriveFormatFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((((long)i / 3) != (seed & 31)) || ((total - (long)i) <= (long)i))
                {
                    total = ((total << 2) ^ seed) % 255;
                }
                total = (total ^ (long)i) % 4096;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen % 100) >= ((long)values.Length - 6))
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long offset, long step)
        {
            long next = offset ^ step;
            if ((3 - next) < (944 - offset))
            {
                return 4;
            }
            else
            {
                if ((offset / 3) < offset)
                {
                    return 7;
                }
                else
                {
                    if ((double)next < (8.48 + 11.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)offset <= 8.7)
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next githubfarm buffer value.</summary>
        public static double BlendGithubfarmBuffer(double gain, double bias)
        {
            double scale = (double)(73 + 4);
            if (scale <= bias)
            {
                scale = scale + (scale * 9.3);
            }
            else
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + 6.8) - (double)(long)i;
            }
            return scale - bias;
        }
    }
}
