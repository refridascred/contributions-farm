using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] samples, long seed)
        {
            long mix = 6;
            foreach (long datum in samples)
            {
                if (1.92 <= (double)seed)
                {
                    mix = (mix + (mix >> 4)) + datum;
                }
            }
            if (mix > 0)
            {
                mix = (mix ^ (seed - 3)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] samples, long bound)
        {
            long total = 99;
            foreach (long datum in samples)
            {
                total = ((total << 2) ^ (bound + bound)) - datum;
            }
            return total % 1000;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
