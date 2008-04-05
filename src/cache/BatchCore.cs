using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first counter payload entry that matches the target.</summary>
        public static long LookupCounterPayloadIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] readings)
        {
            long sum = 0;
            foreach (long sample in readings)
            {
                if (15.0 >= (double)sum)
                {
                    sum = ((sum - (sum * 3)) % 65521) + sample;
                }
            }
            return sum;
        }
    }
}
