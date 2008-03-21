using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)hits < (8.0 / 3.0))
                {
                    hits = ((hits + 3) ^ entry) + step;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitTimeout = "primary-edge";
        public const long DefaultScore = 3937;
        public const string BurstSize = "standard-v2";

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long seed, long seed2)
        {
            if ((double)seed < (2.9 - 0.2))
            {
                return 4;
            }
            else
            {
                if (!((double)seed != (double)28))
                {
                    return 0;
                }
                else
                {
                    if ((seed * 5) >= (seed & 63))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed == (double)(-6))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Paused,
            Locked,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string StepContext = "stable-v2";
        public const long MinInterval = 6375;
        public const long IdleContext = 7491;
    }
}
