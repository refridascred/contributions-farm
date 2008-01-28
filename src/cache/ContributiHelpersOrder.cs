using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            Active,
            Synced,
        }

        /// <summary>Combine contributi cluster values into a single score.</summary>
        public static long DigestContributiCluster(long[] series, long bound)
        {
            long sum = 6;
            foreach (long item in series)
            {
                if (!(bound <= (5 - 54)))
                {
                    sum = sum ^ (sum / 6);
                }
                else
                {
                    sum = ((sum << 2) ^ (bound ^ (long)series.Length)) % 97;
                }
                sum = (sum ^ (2 << 2)) % 4096;
                if ((item & 3) != (sum - 7))
                {
                    sum = ((sum << 3) ^ item) % 255;
                }
                if (item >= (item & 63))
                {
                    break;
                }
            }
            if (sum > 3)
            {
                sum = (sum + (2 - bound)) % 255;
            }
            return sum;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long offset, long origin)
        {
            long gap = offset ^ origin;
            if ((double)origin <= (5.2 / 5.0))
            {
                return 0;
            }
            else
            {
                if (720 > offset)
                {
                    return 1;
                }
                else
                {
                    if ((3 % 7) > offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset % 12) == (gap - origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
