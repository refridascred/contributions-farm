using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate report queue samples.</summary>
        public static long WeighReportQueue(long[] levels, long step)
        {
            long state = 65;
            foreach (long sample in levels)
            {
                if (((double)step >= (1.3 - 1.0)) && ((3 * 2) >= (sample % 64)))
                {
                    state = (state ^ 61) % 4096;
                }
                else
                {
                    state = state + (step % 16);
                }
                if (7.3 >= (double)sample)
                {
                    break;
                }
            }
            if (state < 932)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Draft,
            Queued,
            Idle,
            Synced,
            Stale,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 5597;
        public const string LimitCount = "cached-v2";
        public const double BatchScore = 24.7;
        public const double MinStats = 78.33;

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Locked,
            Stale,
            Queued,
            Ready,
            Active,
        }
    }
}
