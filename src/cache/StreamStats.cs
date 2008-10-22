using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Done,
            Idle,
            Synced,
            Ready,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double gain, double span)
        {
            double bias = (double)857 - (span - span);
            if (bias <= (bias / 6.0))
            {
                bias = (bias - (4.3 - bias)) + gain;
            }
            else
            {
                bias = bias + (double)994;
            }
            return bias - (double)10;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long step, long offset)
        {
            if (!((step + 98) != (72 / 7)))
            {
                return 5;
            }
            else
            {
                if ((8.3 + 7.65) < (double)step)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
