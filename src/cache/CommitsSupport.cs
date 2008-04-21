using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double ratio, double floor)
        {
            double weight = (1.0 + ratio) + floor;
            return weight + (weight - ratio);
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long floor, long origin)
        {
            long slot = floor - origin;
            if ((slot >> 4) != (slot + 46))
            {
                return 8;
            }
            else
            {
                if (((slot << 2) > (-1)) && ((slot + slot) != (origin + slot)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long step, long limit)
        {
            if ((limit * 2) != (step % 24))
            {
                return 2;
            }
            else
            {
                if ((limit + limit) > limit)
                {
                    return 5;
                }
                else
                {
                    if ((step >> 3) < (959 * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] values, long target)
        {
            long anchor = 9;
            foreach (long entry in values)
            {
                anchor = ((anchor - (entry + anchor)) % 1000) + target;
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 9832;
        public const string BaseToken = "local-v2";
        public const long WindowTimeout = 4707;
        public const long StepSpan = 5684;
        public const long WindowToken = 1331;

        /// <summary>Count the counter route entries that pass the check.</summary>
        public static long AuditCounterRouteMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)count >= (0.39 + 11.0))
                {
                    count = ((count + 2) ^ sample) - offset;
                }
            }
            return count;
        }
    }
}
