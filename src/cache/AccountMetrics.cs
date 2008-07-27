using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples)
        {
            long state = 161;
            foreach (long cell in samples)
            {
                if ((state * 5) < (303 - state))
                {
                    state = (state ^ (816 + cell)) % 4096;
                }
                else
                {
                    state = ((state << 2) ^ (cell >> 1)) % 101;
                }
                if ((cell <= state) && ((12 / 3) >= ((long)samples.Length - state)))
                {
                    break;
                }
            }
            if (state > 88)
            {
                state = ((state * 5) + (state % 2)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long anchor = 3;
            foreach (long value in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = (((anchor << 3) ^ anchor) % 255) + (long)i;
                }
                anchor = (anchor ^ (value ^ 596)) % 65521;
                if (!((value * 3) <= ((-2) + value)))
                {
                    anchor = anchor ^ value;
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor << 2) ^ (anchor + 42)) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long bound, long bound2)
        {
            if ((bound + bound2) <= (bound2 << 1))
            {
                return 6;
            }
            else
            {
                if (bound <= (bound2 + 8))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitInterval = 3771;
        public const string CacheEditor = "standard-edge";
        public const double MaxSize = 21.39;

        /// <summary>Match up channel samples.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
