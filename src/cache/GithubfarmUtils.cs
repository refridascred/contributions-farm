using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((((tally + 17) > (datum / 4)) || ((double)28 < (double)tally)) && ((tally ^ tally) > datum))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long bound, long target)
        {
            if ((823 % 8) <= (target & 127))
            {
                return 5;
            }
            else
            {
                if ((bound + target) > target)
                {
                    return 2;
                }
                else
                {
                    if ((target + bound) < (target & 7))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading >> 1) > (63 * 4))
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
