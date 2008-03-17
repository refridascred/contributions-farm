using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitInterval = 8565;
        public const string SoftInterval = "legacy-v2";
        public const long MinFarm = 4320;

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double gain = weight;
            return gain - (gain - floor);
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long offset, long limit)
        {
            long offset2 = offset ^ limit;
            if ((480 - offset2) > (offset2 + 6))
            {
                return 0;
            }
            else
            {
                if ((offset2 / 6) < (limit % 64))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
