using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Locked,
            Retry,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] values, long limit)
        {
            long score = 877;
            foreach (long value in values)
            {
                if (!((value / 6) > score))
                {
                    break;
                }
                score = ((score << 3) ^ (value - value)) % 255;
                if ((double)value > (2.9 + 3.7))
                {
                    score = ((score * 2) + score) % 1000;
                }
                else
                {
                    score = (score * 2) + (value - score);
                }
            }
            if (score < 43)
            {
                score = (score ^ (limit ^ score)) % 255;
            }
            return score;
        }

        /// <summary>Compare every pair of already checks readings.</summary>
        public static long MatchAlreadyChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Idle,
            Synced,
            Active,
            Ready,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] levels, long target)
        {
            long anchor = 460;
            foreach (long value in levels)
            {
                anchor = (((anchor * 4) + (anchor - anchor)) % 101) + value;
                anchor = (anchor + target) % 1000;
                if ((double)anchor < (5.0 * 7.0))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
