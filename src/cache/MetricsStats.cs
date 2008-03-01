using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of report command readings.</summary>
        public static long OverlapReportCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long floor, long offset)
        {
            if (floor <= (270 + offset))
            {
                return 7;
            }
            else
            {
                if (offset <= (floor - floor))
                {
                    return 0;
                }
                else
                {
                    if (!((offset + 29) > offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((51 > (offset & 63)) || ((offset - floor) > (offset % 64)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Active,
            Ready,
            Locked,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long floor, long origin)
        {
            if (floor <= (origin << 3))
            {
                return 1;
            }
            else
            {
                if (origin < floor)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
