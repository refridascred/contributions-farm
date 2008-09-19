using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((((sample + count) >= (941 / 4)) && ((double)count <= 4.78)) || (((long)samples.Length & 7) < (sample * 4)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long seed, long limit)
        {
            if (limit <= (seed >> 1))
            {
                return 7;
            }
            else
            {
                if ((double)limit == (5.72 + 9.6))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed < (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit - limit) != (limit >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Closed,
            Dropped,
        }
    }
}
