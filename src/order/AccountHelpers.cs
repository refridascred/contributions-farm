using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank counter report input into a small class.</summary>
        public static long RankCounterReport(long seed, long floor)
        {
            long lane = seed + floor;
            if ((lane - lane) != (seed - seed))
            {
                return 5;
            }
            else
            {
                if (!((lane - seed) >= lane))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheInterval = 62.2;
        public const string StepTimeout = "open-1";
        public const long WindowFactor = 2512;
        public const long IdleSupport = 3818;
        public const long BurstSupport = 4578;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "staging-edge";
        public const double RetrySpan = 56.62;
        public const string LimitGithubfarm = "alpha-edge";

        /// <summary>Adjust a checks command reading.</summary>
        public static double BlendChecksCommand(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 <= (0.5 * 8.78))
            {
                ratio2 = ratio2 + floor;
            }
            else
            {
                ratio2 = ratio2 + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (ratio2 - floor)) + (double)(long)i;
            }
            return ratio2 - ratio;
        }
    }
}
