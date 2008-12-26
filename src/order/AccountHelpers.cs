using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Look up the position of a buffer already sample.</summary>
        public static long SeekBufferAlreadyIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] levels, long target)
        {
            long mark = 463;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    mark = (mark - (value + mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings)
        {
            long anchor = 156;
            foreach (long reading in readings)
            {
                anchor = (anchor * 5) + (5 + reading);
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstRatio = "fallback-edge";
        public const long HardTimeout = 9856;
        public const string CacheMetrics = "standard-v2";

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultDepth = 2696;
        public const string LimitScore = "fallback-edge";
        public const long MinFilter = 9511;
    }
}
