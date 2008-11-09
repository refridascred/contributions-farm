using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((-91) << 3) == (entry % 64))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
