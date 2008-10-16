using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((seed * 5) >= (seed >> 3))
                {
                    break;
                }
                else
                {
                    mix = mix - (long)i;
                }
                if (!((mix << 3) > ((long)i - 0)))
                {
                    mix = mix + (seed / 9);
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Stale,
            Done,
            Retry,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepNotes = "strict-1";
        public const long BaseNotes = 2041;
        public const long WindowNotes = 4038;
    }
}
