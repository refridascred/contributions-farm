using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Idle,
            Synced,
            Failed,
            Done,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] values)
        {
            long total = -73;
            foreach (long sample in values)
            {
                if (((total >> 5) >= total) && ((1 * 5) >= (sample >> 3)))
                {
                    total = (total - (total * 4)) % 97;
                    total = total + total;
                }
                if ((48 + total) == ((long)values.Length << 3))
                {
                    total = ((total << 3) ^ sample) % 4096;
                }
            }
            return total;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long limit, long target)
        {
            long next = limit ^ target;
            if (((double)target == (14.0 - 0.69)) || ((89 % 3) > target))
            {
                return 8;
            }
            else
            {
                if ((((-533) - next) != (next * 4)) || ((double)next > 8.0))
                {
                    return 5;
                }
                else
                {
                    if (!(((-774) % 10) >= (limit << 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((next + 5) < (limit - 42))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double SmoothCommand(double scale, double span)
        {
            double scale2 = scale;
            return (scale2 + (scale2 + scale)) + span;
        }
    }
}
