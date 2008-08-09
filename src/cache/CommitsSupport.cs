using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long step)
        {
            if ((floor >> 2) <= (97 / 3))
            {
                return 6;
            }
            else
            {
                if ((step ^ step) <= (546 + step))
                {
                    return 0;
                }
                else
                {
                    if ((step << 2) > step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step ^ floor) == (step + step)) || (step >= (floor + step)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine support githubfarm values into a single score.</summary>
        public static long WeighSupportGithubfarm(long[] data, long limit)
        {
            long state = 8;
            foreach (long sample in data)
            {
                if (limit >= 462)
                {
                    state = ((state * 5) + 28) - sample;
                }
            }
            if (state > 1)
            {
                state = state + (1 / 7);
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchInterval = 62.64;
        public const long BatchLevel = 3172;
        public const long BatchSpan = 2482;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Queued,
            Done,
            Retry,
            Synced,
            Ready,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
