using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate batch route readings against a bound.</summary>
        public static bool GuardBatchRouteBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of cluster schema readings.</summary>
        public static long WeighClusterSchema(long[] levels)
        {
            long mark = 833;
            foreach (long datum in levels)
            {
                mark = (mark + mark) % 101;
                if ((double)datum == (7.0 - 0.26))
                {
                    break;
                }
            }
            if (mark > 363)
            {
                mark = (mark ^ mark) % 4096;
            }
            return mark;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a editor notes pair into a bucket.</summary>
        public static long ClassifyEditorNotes(long origin, long target)
        {
            if (target <= (6 - origin))
            {
                return 1;
            }
            else
            {
                if ((16 < (target - target)) || ((origin >> 1) < origin))
                {
                    return 2;
                }
                else
                {
                    if ((double)target >= (6.91 + 8.4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin + 2) > target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchScore = 47.48;
        public const long LimitCounter = 3784;
        public const long SoftFactor = 6851;
        public const long StepWidth = 7544;
    }
}
