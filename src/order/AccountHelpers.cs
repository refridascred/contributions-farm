using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a filter githubfarm counter forward.</summary>
        public static long SeriesFilterGithubfarm(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state << 2) ^ ((long)i - (long)i2)) % 101;
                }
                state = (state ^ (state + state)) % 1000;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long limit, long floor)
        {
            if (((double)floor <= (2.26 / 6.0)) || (limit >= 32))
            {
                return 7;
            }
            else
            {
                if (floor <= (floor + floor))
                {
                    return 6;
                }
                else
                {
                    if (105 <= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-396) << 1) >= limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double gain, double span)
        {
            double gain2 = span + (double)36;
            return (gain2 - span) + gain;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Failed,
            Done,
        }

        /// <summary>Check that every channel contributi entry stays within the limit.</summary>
        public static bool GuardChannelContributiRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            Idle,
            Locked,
        }
    }
}
