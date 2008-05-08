using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor + (anchor + (long)i)) % 97;
                if ((1 / 2) < step)
                {
                    break;
                }
                else
                {
                    anchor = ((anchor * 2) + ((long)i * 5)) % 65521;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long seed, long seed2)
        {
            if ((13.0 + 3.91) >= (double)seed)
            {
                return 8;
            }
            else
            {
                if ((seed2 << 2) <= seed2)
                {
                    return 5;
                }
                else
                {
                    if ((525 - seed2) >= (714 % 12))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double ratio, double offset)
        {
            double scale = ratio;
            if (scale >= (double)191)
            {
                scale = (scale - scale) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (double)325;
        }
    }
}
