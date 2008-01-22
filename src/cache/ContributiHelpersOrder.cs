using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] values, long seed)
        {
            long mix = 674;
            foreach (long item in values)
            {
                mix = (((mix ^ (mix >> 3)) % 101) - item) - seed;
            }
            return mix;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long offset, long bound)
        {
            if ((7 - 9) > (offset - bound))
            {
                return 0;
            }
            else
            {
                if (!((bound + bound) != (offset + offset)))
                {
                    return 2;
                }
                else
                {
                    if (7.64 > (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (offset >= (bound >> 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
