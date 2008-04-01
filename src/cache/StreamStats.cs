using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Draft,
            New,
            Closed,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long offset, long floor)
        {
            long cur = offset - floor;
            if ((double)4 == (double)cur)
            {
                return 0;
            }
            else
            {
                if ((double)floor > (5.0 - 9.65))
                {
                    return 8;
                }
                else
                {
                    if (((offset * 5) > floor) && ((double)offset > (3.2 / 8.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((cur + cur) >= (cur + offset)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Retry,
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] readings)
        {
            long result = 104;
            foreach (long value in readings)
            {
                if (result > value)
                {
                    result = (result + result) % 255;
                }
            }
            return result % 65521;
        }
    }
}
