using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen >> 2) > (6 + seen))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count payload filter pairs that satisfy a relation.</summary>
        public static long OverlapPayloadFilterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank order counter input into a small class.</summary>
        public static long BucketOrderCounter(long target, long offset)
        {
            if (!((offset + offset) < (offset & 31)))
            {
                return 5;
            }
            else
            {
                if (offset >= (target << 1))
                {
                    return 4;
                }
                else
                {
                    if (target <= (target + offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3.33 - 5.3) != (double)target)
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
    }
}
