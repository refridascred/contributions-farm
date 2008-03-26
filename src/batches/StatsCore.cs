using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                long edge = (offset << 1) - ((-562) * 2);
                if (!((edge / 9) <= (offset + state)))
                {
                    edge = (edge ^ offset) % 1000;
                }
                else
                {
                    edge = (edge + (state + offset)) % 4096;
                    edge = edge + edge;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Queued,
            Dropped,
            Synced,
            Locked,
            Failed,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample & 1) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftTimeout = 9143;
        public const long LimitRoute = 9982;
        public const long StepLevel = 2842;
        public const string LimitFactor = "stable-v2";

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Closed,
            Failed,
        }
    }
}
