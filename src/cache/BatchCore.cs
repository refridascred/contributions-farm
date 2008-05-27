using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((sample * 4) <= (origin - sample)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((2 + 50) != (step - matches))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
