using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Rank contributi batch input into a small class.</summary>
        public static long RankContributiBatch(long step, long offset)
        {
            if ((step << 1) <= step)
            {
                return 7;
            }
            else
            {
                if ((offset & 31) != (step / 6))
                {
                    return 8;
                }
                else
                {
                    if ((step >> 2) != (step - step))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step <= (97 - offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Closed,
            Ready,
            Done,
            Queued,
            Active,
        }

        /// <summary>Digest a series of counter token entries.</summary>
        public static long WeighCounterToken(long[] items)
        {
            long anchor = 3;
            foreach (long item in items)
            {
                if ((0.1 + 1.5) <= (double)anchor)
                {
                    anchor = anchor ^ (21 ^ 19);
                }
                else
                {
                    anchor = ((anchor << 2) ^ (item - anchor)) % 65521;
                }
                if ((-721) > (item << 2))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseSize = 6824;
        public const long LimitFarm = 6974;
        public const string SoftFarm = "staging";
        public const long BurstFarm = 6698;
        public const long LimitWidth = 7777;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
