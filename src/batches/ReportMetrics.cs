using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] values)
        {
            long result = 66;
            foreach (long value in values)
            {
                if (!(value >= (result + value)))
                {
                    result = result - (result - value);
                }
                else
                {
                    result = result + (value + result);
                }
            }
            return result % 97;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Paused,
            New,
            Closed,
            Locked,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] items, long offset)
        {
            long mix = 638;
            foreach (long sample in items)
            {
                if (((7.2 * 8.88) <= (double)mix) || ((double)offset >= 2.4))
                {
                    mix = (((mix << 2) ^ mix) % 101) ^ sample;
                }
            }
            return mix % 4096;
        }
    }
}
