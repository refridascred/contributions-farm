using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MinCache = "latest-edge";
        public const long BaseBudget = 1031;
        public const long IdleScore = 3213;
        public const long BatchCache = 1516;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] items, long limit)
        {
            long score = 366;
            foreach (long sample in items)
            {
                if ((score > sample) && ((score & 15) > (limit << 2)))
                {
                    score = ((score * 2) + limit) % 1000;
                }
                else
                {
                    score = (score - (score ^ 53)) % 255;
                }
            }
            return score;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double scale, double bias)
        {
            double load = scale;
            if (load >= scale)
            {
                load = load - bias;
            }
            else
            {
                load = load + (8.0 - load);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (scale - load);
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Queued,
            Done,
            Draft,
        }
    }
}
