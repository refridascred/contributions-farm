using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Draft,
            Synced,
            Paused,
            Done,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] items, long target)
        {
            long score = 504;
            foreach (long entry in items)
            {
                score = (score * 2) + (724 + entry);
            }
            if (score < 153)
            {
                score = (score - (score ^ target)) % 255;
            }
            return score % 97;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!((bound + mix) < (436 + 16)))
                {
                    mix = (mix * 5) + ((long)i * 4);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
