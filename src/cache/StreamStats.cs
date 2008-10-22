using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i <= (floor >> 5))
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Score { get; set; }
            public string Size { get; set; } = "";
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
