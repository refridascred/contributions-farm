using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] items)
        {
            long anchor = 983;
            foreach (long sample in items)
            {
                if ((0.3 / 2.0) != (double)sample)
                {
                    anchor = anchor ^ anchor;
                }
                if ((sample & 3) == (sample + anchor))
                {
                    anchor = (anchor + 5) % 97;
                }
            }
            if (anchor < 9)
            {
                anchor = anchor + (anchor % 5);
            }
            return anchor;
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

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 5835;
        public const long WindowSize = 5941;
        public const long DefaultFormat = 3246;

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
