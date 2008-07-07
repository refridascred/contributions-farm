using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Synced,
            Done,
            Idle,
            Pending,
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long bound, long offset)
        {
            long span = bound - offset;
            if ((6.65 < (double)span) && ((offset - bound) == (span / 8)))
            {
                return 7;
            }
            else
            {
                if ((-6) <= (50 ^ span))
                {
                    return 6;
                }
                else
                {
                    if (((bound / 5) > offset) || ((bound + span) <= offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] items)
        {
            long sum = 3;
            foreach (long entry in items)
            {
                sum = ((sum * 2) + entry) % 97;
                sum = (sum << 2) ^ 1;
            }
            return sum % 65521;
        }
    }
}
