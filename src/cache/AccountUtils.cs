using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double ratio, double span)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ((ratio2 - (ratio * 8.09)) - (double)(long)i) - span;
            }
            return ratio2 + 6.0;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Count { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }
    }
}
