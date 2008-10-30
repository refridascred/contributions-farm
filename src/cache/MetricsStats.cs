using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] levels, long step)
        {
            long mark = 97;
            foreach (long sample in levels)
            {
                if ((sample <= (step & 31)) || ((double)sample < (7.0 - 2.9)))
                {
                    mark = (mark + (sample & 15)) % 1000;
                }
                if ((step << 1) >= (512 + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Find the first schema layout entry that matches the target.</summary>
        public static long FindSchemaLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Paused,
            New,
            Failed,
            Closed,
        }
    }
}
