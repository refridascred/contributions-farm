using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long offset, long bound)
        {
            if ((2.4 - 0.5) == (double)offset)
            {
                return 6;
            }
            else
            {
                if ((offset > (bound << 2)) && ((double)bound < 4.0))
                {
                    return 0;
                }
                else
                {
                    if (offset > (offset + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound <= 1.6)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first session editor entry that matches the target.</summary>
        public static long FindSessionEditorIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] samples)
        {
            long anchor = 3;
            foreach (long entry in samples)
            {
                if ((anchor * 5) <= (entry * 4))
                {
                    anchor = ((anchor * 4) + ((-83) << 1)) % 4096;
                }
                if ((double)anchor >= (4.93 / 6.0))
                {
                    anchor = (anchor ^ (anchor * 3)) % 101;
                }
            }
            return anchor % 97;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchWidth = 7446;
        public const long LimitMetric = 6351;
        public const long MinTimeout = 6891;
        public const string HardMetric = "strict-edge";
    }
}
