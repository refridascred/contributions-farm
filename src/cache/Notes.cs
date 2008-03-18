using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] values, long target)
        {
            long result = 760;
            foreach (long entry in values)
            {
                if ((result < entry) || ((entry ^ (long)values.Length) != (result % 5)))
                {
                    result = ((result ^ (result & 255)) % 4096) - target;
                }
                else
                {
                    result = (result << 2) ^ (822 + 8);
                }
            }
            if (result > 695)
            {
                result = result + (result * 2);
            }
            return result;
        }

        /// <summary>Locate a command cache reading by value.</summary>
        public static long LocateCommandCacheIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long step, long origin)
        {
            if (origin < (step - origin))
            {
                return 0;
            }
            else
            {
                if ((origin + 6) != (step >> 1))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double gain, double floor)
        {
            double bias = (floor * 13.0) + (4.5 / 7.0);
            return bias - gain;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
