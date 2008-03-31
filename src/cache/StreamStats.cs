using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long seed, long seed2)
        {
            long slot = seed + seed2;
            if (((seed2 >> 5) >= (seed - slot)) || ((double)slot < (double)9))
            {
                return 8;
            }
            else
            {
                if ((slot / 5) <= (seed % 16))
                {
                    return 7;
                }
                else
                {
                    if ((seed * 2) <= (slot >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-11) * 3) > (seed2 + seed2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of session githubfarm readings.</summary>
        public static long TallySessionGithubfarm(long[] levels, long origin)
        {
            long result = 7;
            foreach (long cell in levels)
            {
                if (origin >= (origin * 4))
                {
                    result = ((result * 3) + (result & 15)) - cell;
                }
            }
            return result;
        }
    }
}
