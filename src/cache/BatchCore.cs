using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Dropped,
            Idle,
            Locked,
        }

        /// <summary>Roll a checks report counter forward.</summary>
        public static long RollChecksReport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Idle,
            Retry,
            Queued,
            Dropped,
            Pending,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
