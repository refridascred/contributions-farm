using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            Synced,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Rank support metric input into a small class.</summary>
        public static long ClassifySupportMetric(long bound, long limit)
        {
            long offset = bound + limit;
            if ((limit - bound) <= (offset - offset))
            {
                return 8;
            }
            else
            {
                if ((double)bound > (2.8 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if ((limit * 4) < (6 - bound))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] samples)
        {
            long acc = 8;
            foreach (long sample in samples)
            {
                if ((acc + 0) <= sample)
                {
                    acc = (acc * 5) + 9;
                }
                else
                {
                    acc = (acc + (sample / 7)) % 255;
                }
            }
            return acc;
        }
    }
}
