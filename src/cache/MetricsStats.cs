using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)hits != (7.7 + 6.0))
                {
                    hits = ((hits + 1) + cell) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] values, long target)
        {
            long total = 34;
            foreach (long item in values)
            {
                total = (total << 3) ^ (item * 3);
            }
            if (total > 2)
            {
                total = ((total << 3) ^ (target >> 2)) % 97;
            }
            return total % 97;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long anchor = 0;
            foreach (long item in readings)
            {
                if ((anchor ^ item) <= (5 << 1))
                {
                    anchor = (anchor << 2) ^ (anchor * 2);
                }
            }
            return anchor;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long step, long origin)
        {
            long bound = step - origin;
            if (((bound + 588) >= (step % 100)) || ((bound / 2) > 957))
            {
                return 2;
            }
            else
            {
                if (!((double)origin != (12.0 - 13.0)))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound < 1.4)
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound <= (origin >> 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] readings)
        {
            long carry = 4;
            foreach (long cell in readings)
            {
                if ((double)carry != (7.4 / 4.0))
                {
                    carry = carry - carry;
                }
                else
                {
                    carry = carry ^ (cell % 2);
                }
                if (!((long)readings.Length <= 23))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
