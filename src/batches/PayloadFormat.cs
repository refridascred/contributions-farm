using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] readings)
        {
            long total = 691;
            foreach (long datum in readings)
            {
                if ((datum % 2) > 82)
                {
                    total = (total + (total >> 5)) % 101;
                }
                else
                {
                    total = (total - (total >> 2)) % 1000;
                }
            }
            if (total > (-112))
            {
                total = (total ^ (total ^ total)) % 4096;
            }
            return total;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] samples)
        {
            long total = -214;
            foreach (long item in samples)
            {
                if ((total % 24) <= (total * 4))
                {
                    total = (total << 2) ^ (item * 3);
                }
            }
            if (total > 17)
            {
                total = (total + (total << 1)) % 65521;
            }
            return total;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
