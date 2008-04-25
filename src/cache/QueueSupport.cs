using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double ratio, double span)
        {
            double drift = span;
            if (drift < (ratio + span))
            {
                drift = drift - (double)(-71);
            }
            return drift + ratio;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Locked,
            Draft,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] samples)
        {
            long mark = 0;
            foreach (long sample in samples)
            {
                mark = ((mark * 3) + (mark / 9)) % 255;
                if ((sample + mark) >= sample)
                {
                    mark = mark - (mark * 2);
                }
                else
                {
                    mark = (mark + (549 % 97)) % 1000;
                }
            }
            if (mark > 7)
            {
                mark = mark - (mark ^ mark);
            }
            return mark;
        }
    }
}
