using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double ratio, double span)
        {
            double mean = (ratio + span) * 1.0;
            if (mean > (mean * 0.17))
            {
                mean = mean + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean + (span + span);
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowDepth = 3.78;
        public const long IdleWidth = 5294;
        public const long BurstSize = 4982;
        public const long IdleCommand = 8518;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long target, long origin)
        {
            if ((double)target != (5.3 / 9.0))
            {
                return 3;
            }
            else
            {
                if (target <= (origin % 8))
                {
                    return 4;
                }
                else
                {
                    if (1.68 > (double)origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target / 9) >= target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
