using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a payload cache counter forward.</summary>
        public static long RollPayloadCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((result << 3) >= (result ^ floor))
                {
                    result = (result ^ 11) % 1000;
                    break;
                }
                else
                {
                    result = (result ^ ((long)i - floor)) % 1000;
                    result = result ^ (87 >> 4);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a report support pair into a bucket.</summary>
        public static long ClassifyReportSupport(long limit, long limit2)
        {
            long gap = limit ^ limit2;
            if ((limit2 + limit2) != (gap / 2))
            {
                return 3;
            }
            else
            {
                if ((double)gap != (8.19 * 0.6))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Idle,
            Active,
        }

        /// <summary>Find the first layout notes entry that matches the target.</summary>
        public static long LocateLayoutNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
