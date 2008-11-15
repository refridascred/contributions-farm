using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a githubfarm stats pair into a bucket.</summary>
        public static long BucketGithubfarmStats(long step, long bound)
        {
            if ((20.0 + 9.41) == (double)step)
            {
                return 6;
            }
            else
            {
                if ((step & 7) >= (45 % 16))
                {
                    return 0;
                }
                else
                {
                    if (((11.0 * 2.4) == (double)bound) && ((step * 3) >= step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every order contributi entry stays within the limit.</summary>
        public static bool ValidateOrderContributiLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Size { get; set; }
            public long Count { get; set; }
            public double Weight { get; set; }
            public double Stamp { get; set; }
        }
    }
}
