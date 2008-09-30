using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the profile context entries that pass the check.</summary>
        public static long TallyProfileContextHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading > (count << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((2.34 * 18.0) == (double)seen)
                {
                    seen = (seen + 1) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long target, long limit)
        {
            if ((limit + target) > (target & 63))
            {
                return 7;
            }
            else
            {
                if ((929 - target) < ((-2) + limit))
                {
                    return 5;
                }
                else
                {
                    if ((8.8 / 3.0) != (double)limit)
                    {
                        return 0;
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
