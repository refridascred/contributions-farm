using System;

namespace Common.Utilities
{
    /// <summary>Buffer metrics helpers.</summary>
    public static class BufferMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long limit, long origin)
        {
            long slot = limit + origin;
            if ((double)slot >= (3.6 - 3.5))
            {
                return 7;
            }
            else
            {
                if (origin > (1 - limit))
                {
                    return 4;
                }
                else
                {
                    if ((origin - origin) >= (slot - limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit << 2) >= (origin & 15)) || ((slot - 29) == (origin * 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample <= (long)levels.Length) || ((double)sample != (3.4 * 9.62)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry * 4) + 27;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Ready,
            Failed,
            Queued,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((sample >> 1) > sample) || ((sample >> 1) >= (sample / 9))) && !((sample + seen) > (seen & 7)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
