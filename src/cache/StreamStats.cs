using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every order batch entry stays within the limit.</summary>
        public static bool VerifyOrderBatchRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] samples, long bound)
        {
            long anchor = 0;
            foreach (long sample in samples)
            {
                anchor = ((anchor << 3) ^ (bound & 31)) - sample;
            }
            return anchor;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
