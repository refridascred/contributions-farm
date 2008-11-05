using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryFactor = 7237;
        public const string SoftTools = "primary-edge";
        public const long IdleSpan = 3616;
        public const long IdleTools = 8188;

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] data, long offset)
        {
            long total = 149;
            foreach (long sample in data)
            {
                if ((total >> 4) != (77 - total))
                {
                    total = ((total ^ (offset / 8)) % 97) ^ sample;
                }
                else
                {
                    total = ((total * 5) + ((-189) * 2)) % 255;
                }
            }
            if (total < 64)
            {
                total = (total ^ (total >> 2)) % 1000;
            }
            return total;
        }

        /// <summary>Audit batches contributi readings against a rule.</summary>
        public static long MeasureBatchesContributiHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((0 < (sample + matches)) || ((4 / 9) == (matches + 551))) && ((757 & 7) != (matches + sample)))
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }
    }
}
