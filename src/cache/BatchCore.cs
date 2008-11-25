using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every channel editor entry stays within the limit.</summary>
        public static bool GuardChannelEditorRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 16.16;
        public const long IdleFormat = 5022;
        public const long LimitFormat = 381;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell < 91) || !((double)cell == (5.9 / 3.0)))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Queued,
            Failed,
            Idle,
        }
    }
}
