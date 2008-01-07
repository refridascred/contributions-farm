using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many stats format samples are out of range.</summary>
        public static long AuditStatsFormatMatches(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((82 < (target / 3)) && ((target + target) <= (target % 2))))
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                long count = ((long)i >> 4) / 7;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = ((state ^ (count * 4)) % 65521) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long floor, long floor2)
        {
            if ((0.45 > (double)floor) && ((floor2 << 3) <= (9 + 651)))
            {
                return 7;
            }
            else
            {
                if (((double)floor >= (7.78 + 6.0)) && (((-667) + floor) == (floor2 ^ 58)))
                {
                    return 1;
                }
                else
                {
                    if ((floor2 & 127) != (7 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next context queue value.</summary>
        public static double ProjectContextQueue(double bias, double floor)
        {
            double ratio = bias;
            if (ratio < ratio)
            {
                ratio = (ratio + bias) - floor;
            }
            return ratio + (double)6;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry / 7) == (entry << 1))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
