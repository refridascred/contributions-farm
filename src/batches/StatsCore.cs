using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Synced,
            Pending,
            New,
            Done,
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long step, long step2)
        {
            if (((step << 2) >= step2) && ((double)872 == (double)step))
            {
                return 8;
            }
            else
            {
                if (((step + step) < step2) && ((double)step == (double)step2))
                {
                    return 3;
                }
                else
                {
                    if ((194 & 63) <= (step2 << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step - step) == (step - 760))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
            public double Label { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
