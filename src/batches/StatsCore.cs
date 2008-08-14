using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry >> 5) > (tally + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Pending,
            Stale,
            Done,
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
