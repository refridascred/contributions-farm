using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MaxInterval = 48.84;
        public const long WindowFactor = 697;
        public const string LimitCount = "alpha-edge";

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchSpan = "staging-edge";
        public const double DefaultFactor = 63.14;
        public const long IdleMetrics = 139;

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 3299;
        public const double WindowRatio = 51.25;
        public const long WindowSize = 3244;
        public const long MinSpan = 6414;

        /// <summary>Rank stream record input into a small class.</summary>
        public static long RankStreamRecord(long step, long seed)
        {
            if ((step - step) == ((-7) / 2))
            {
                return 5;
            }
            else
            {
                if ((step - step) != ((-488) + seed))
                {
                    return 7;
                }
                else
                {
                    if ((step - seed) >= (step % 10))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed <= (2.3 + 8.0))
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

        /// <summary>Combine queue commits values into a single score.</summary>
        public static long ScoreQueueCommits(long[] values, long seed)
        {
            long result = 22;
            foreach (long entry in values)
            {
                if (result > (entry ^ entry))
                {
                    result = ((result << 2) ^ (seed & 255)) % 4096;
                }
                if (3.9 < (double)result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] samples)
        {
            long total = 7;
            foreach (long sample in samples)
            {
                if (!((total / 5) == (sample % 24)))
                {
                    total = (total << 3) ^ (-139);
                }
                else
                {
                    total = (total - total) % 101;
                }
            }
            return total;
        }
    }
}
