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

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (3 >= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                mark = mark - (mark % 97);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
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
