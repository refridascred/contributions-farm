using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Closed,
            Ready,
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a layout buffer value against two limits.</summary>
        public static long ClassifyLayoutBuffer(long seed, long seed2)
        {
            long diff = seed + seed2;
            if ((diff & 255) >= (seed << 1))
            {
                return 6;
            }
            else
            {
                if (((double)seed < (1.95 * 4.9)) && ((5.3 / 5.0) != (double)seed))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Retry,
            Paused,
            Queued,
            Failed,
        }
    }
}
