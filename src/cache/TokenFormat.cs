using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double ratio, double offset)
        {
            double weight = (ratio / 6.0) * 2.8;
            return weight + (offset / 5.0);
        }

        /// <summary>Grade a profile githubfarm value against two limits.</summary>
        public static long ClassifyProfileGithubfarm(long target, long bound)
        {
            if ((56 + bound) > (target << 3))
            {
                return 5;
            }
            else
            {
                if (((96 + 4) > bound) || (bound < (bound >> 4)))
                {
                    return 1;
                }
                else
                {
                    if (((target + 70) >= (target >> 2)) && ((double)target >= (13.0 + 5.6)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target - bound) <= target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
