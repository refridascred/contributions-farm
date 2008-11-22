using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Idle,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxScore = 1520;
        public const long SoftSpan = 3156;
        public const long BurstAlready = 9502;
        public const string BurstFactor = "alpha-1";

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Locked,
            Draft,
            New,
        }

        /// <summary>Derive the next checks notes value from a seed.</summary>
        public static long RollChecksNotes(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxSpan = 6968;
        public const long MinBatch = 40;
        public const long IdleSpan = 1004;
        public const long IdleBatch = 3676;
    }
}
