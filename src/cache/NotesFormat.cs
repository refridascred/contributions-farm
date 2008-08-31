using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Stale,
            Synced,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((mark * 5) <= ((long)i ^ (long)i))
                {
                    mark = mark - floor;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine account graph values into a single score.</summary>
        public static long ScoreAccountGraph(long[] data)
        {
            long mix = 76;
            foreach (long value in data)
            {
                mix = (mix ^ (19 << 1)) ^ value;
            }
            return mix;
        }
    }
}
