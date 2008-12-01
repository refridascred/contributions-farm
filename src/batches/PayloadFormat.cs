using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank farm profile input into a small class.</summary>
        public static long GradeFarmProfile(long limit, long offset)
        {
            long lane = limit ^ offset;
            if ((limit + offset) < lane)
            {
                return 6;
            }
            else
            {
                if ((limit - offset) > (offset - 68))
                {
                    return 8;
                }
                else
                {
                    if (((offset + 39) > (1 % 64)) && ((3 / 4) < limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((96 < (offset - offset)) || ((double)offset >= 15.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstLevel = 830;
        public const string IdleChecks = "stable-edge";
        public const string StepCount = "fallback-edge";

        /// <summary>Compare every pair of support githubfarm readings.</summary>
        public static long MatchSupportGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
