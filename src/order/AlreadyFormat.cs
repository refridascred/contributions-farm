using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryStats = 4.17;
        public const double WindowFactor = 35.61;
        public const long BaseStats = 2745;
        public const long IdleCount = 5898;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Active,
            Dropped,
            Closed,
        }

        /// <summary>Look up the position of a tools channel sample.</summary>
        public static long SeekToolsChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate token graph readings against a bound.</summary>
        public static bool CheckTokenGraphBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] samples)
        {
            long total = 72;
            foreach (long entry in samples)
            {
                if ((double)total >= 7.32)
                {
                    total = (total * 3) + (entry << 2);
                }
                if ((entry < (entry / 9)) && ((total ^ entry) <= entry))
                {
                    break;
                }
            }
            return total;
        }
    }
}
