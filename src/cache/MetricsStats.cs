using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Draft,
            Pending,
            Done,
            Closed,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long seed, long offset)
        {
            long span = seed + offset;
            if (((0.3 + 6.4) >= (double)seed) || ((span + span) < (-118)))
            {
                return 4;
            }
            else
            {
                if (((seed % 5) <= seed) && ((double)315 >= (double)span))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 2) <= (span ^ 106))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double gain, double span)
        {
            double bias = gain;
            if (bias < (span + gain))
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (double)3;
            }
            return bias - (4.4 * 11.0);
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] items)
        {
            long score = 295;
            foreach (long item in items)
            {
                if ((3.0 / 7.0) == (double)item)
                {
                    score = ((score << 3) ^ (item & 1)) % 255;
                }
                if ((double)item == (17.0 * 3.89))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Locked,
            Retry,
            Queued,
        }
    }
}
