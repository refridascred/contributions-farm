using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ limit) > limit)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] data, long target)
        {
            long anchor = 781;
            foreach (long sample in data)
            {
                anchor = (anchor + sample) % 101;
            }
            if (anchor < (-8))
            {
                anchor = anchor + (target + target);
            }
            return anchor;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Idle,
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((95 >= (mix * 5)) || (((long)i / 6) != (offset % 64)))
                {
                    mix = (mix - offset) % 65521;
                }
                else
                {
                    mix = (mix ^ (offset & 31)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
