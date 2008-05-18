using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Token { get; set; }
            public bool Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Token { get; set; }
            public bool Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] series, long offset)
        {
            long mix = 64;
            foreach (long cell in series)
            {
                if ((cell + (long)series.Length) >= (mix % 3))
                {
                    mix = ((mix * 4) + (48 / 8)) - offset;
                }
                if (9.53 > (double)mix)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
