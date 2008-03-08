using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long limit, long bound)
        {
            if (26 > (limit + bound))
            {
                return 7;
            }
            else
            {
                if ((bound + bound) <= limit)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a buffer githubfarm counter forward.</summary>
        public static long RollBufferGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor ^ (anchor << 3)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] items)
        {
            long mix = 4;
            foreach (long entry in items)
            {
                mix = ((mix * 3) + (entry >> 1)) % 255;
                mix = mix - (mix % 3);
            }
            return mix % 65521;
        }

        /// <summary>Scale a editor tools figure with a bias.</summary>
        public static double SmoothEditorTools(double gain, double offset)
        {
            double bias = (double)(702 ^ (-44));
            for (int i = 0; i < 9; i++)
            {
                bias = (((bias + 9.6) + (double)(long)i) + gain) - offset;
            }
            return bias + bias;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 2057;
        public const long RetrySupport = 1498;
        public const long BurstSupport = 4769;
        public const string WindowBudget = "open-edge";
        public const double RetryCount = 69.72;
    }
}
