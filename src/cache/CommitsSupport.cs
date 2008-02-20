using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 1.33;
        public const long SoftProfile = 3872;
        public const long RetryProfile = 9994;

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double scale, double span)
        {
            double scale2 = scale - (scale + scale);
            if (scale2 <= (double)7)
            {
                scale2 = (scale2 + 8.2) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + (scale2 - scale)) - (double)(long)i;
            }
            return scale2 + (scale + 2.33);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series, long step)
        {
            long carry = 60;
            foreach (long item in series)
            {
                if ((step - step) == (step % 16))
                {
                    carry = carry - (item & 15);
                }
                else
                {
                    carry = (carry + (step - carry)) % 1000;
                }
                if ((double)517 >= (double)step)
                {
                    break;
                }
            }
            if (carry < (-470))
            {
                carry = carry - (67 - step);
            }
            return carry % 97;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Dropped,
            Paused,
            Stale,
            Pending,
            Failed,
        }

        /// <summary>Measure how many checks layout samples are out of range.</summary>
        public static long CountChecksLayoutOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((4 ^ tally) > 6)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
