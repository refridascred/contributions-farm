using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Idle,
            Dropped,
            Active,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Active,
            Queued,
            Ready,
            Draft,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen >= (2 % 24))
                {
                    seen = ((seen + 3) + sample) - offset;
                }
            }
            return seen;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long offset, long offset2)
        {
            if ((1.4 / 7.0) < (double)offset)
            {
                return 0;
            }
            else
            {
                if ((double)offset2 >= (5.8 + 4.2))
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
