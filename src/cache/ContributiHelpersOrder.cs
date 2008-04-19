using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Ready,
            Queued,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long limit, long seed)
        {
            long step = limit ^ seed;
            if ((7.0 / 5.0) >= (double)step)
            {
                return 8;
            }
            else
            {
                if ((limit + seed) > (seed * 2))
                {
                    return 3;
                }
                else
                {
                    if (5.72 <= (double)step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of checks window readings.</summary>
        public static long WeighChecksWindow(long[] data, long step)
        {
            long mix = -502;
            foreach (long entry in data)
            {
                mix = ((mix + 62) + entry) - step;
            }
            if (mix > 63)
            {
                mix = mix - (921 - mix);
            }
            return mix;
        }
    }
}
