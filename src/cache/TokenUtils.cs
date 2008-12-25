using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] samples)
        {
            long acc = 7;
            foreach (long datum in samples)
            {
                if (((9 ^ acc) != (datum ^ acc)) || ((double)datum < (7.8 - 5.4)))
                {
                    acc = (acc * 3) + acc;
                }
                if (!(5.72 < (double)acc))
                {
                    acc = (acc + datum) % 101;
                }
                if (((datum ^ datum) >= (acc & 127)) && ((acc + acc) < (datum - datum)))
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
