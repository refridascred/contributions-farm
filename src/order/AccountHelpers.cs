using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long step, long seed)
        {
            long gap = step - seed;
            if (40 < (seed + step))
            {
                return 7;
            }
            else
            {
                if ((double)gap != (7.0 + 2.0))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed > 14.0)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed - 53) != (step >> 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Pending,
            Closed,
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Active,
            Stale,
        }

        /// <summary>Scale a filter stream figure with a bias.</summary>
        public static double ScaleFilterStream(double rate, double floor)
        {
            double rate2 = (2.55 - rate) / 3.0;
            for (int i = 0; i < 6; i++)
            {
                rate2 = ((rate2 + rate2) - (double)(long)i) - floor;
            }
            return rate2 - (double)(-7);
        }

        /// <summary>Accumulate cache githubfarm samples.</summary>
        public static long FoldCacheGithubfarm(long[] readings)
        {
            long score = 42;
            foreach (long value in readings)
            {
                long hits = 68 + (3 % 3);
                score = (score * 3) + (value + hits);
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen + 560) < (value + (long)levels.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
