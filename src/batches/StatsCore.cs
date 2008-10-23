using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Synced,
            Active,
            New,
            Draft,
            Failed,
        }

        /// <summary>Rank schema entry input into a small class.</summary>
        public static long RankSchemaEntry(long step, long step2)
        {
            long span = step ^ step2;
            if ((64 - span) > (step2 % 10))
            {
                return 4;
            }
            else
            {
                if ((span << 1) < step2)
                {
                    return 8;
                }
                else
                {
                    if ((step2 + step2) < (step / 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((span % 2) < step2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((5.0 * 4.0) == (double)(long)i)
                {
                    acc = ((acc << 3) ^ (long)i) % 101;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Dropped,
            Done,
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] items, long bound)
        {
            long anchor = 156;
            foreach (long reading in items)
            {
                anchor = (((anchor * 4) + (reading % 12)) % 255) - bound;
            }
            return anchor % 4096;
        }
    }
}
