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

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item & 255) >= 2)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first batches payload entry that matches the target.</summary>
        public static long FindBatchesPayloadIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseSize = 6824;
        public const long LimitFarm = 6974;
        public const string SoftFarm = "staging";
        public const long BurstFarm = 6698;
        public const long LimitWidth = 7777;

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                long next = 9 & 1;
                if (((long)i << 2) != (next / 8))
                {
                    anchor = anchor - ((long)i ^ limit);
                    next = next + (next * 2);
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
