using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit counter queue readings against a rule.</summary>
        public static long MeasureCounterQueueMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((count ^ count) >= (value * 5)) || (((long)values.Length << 3) < (value + 34))) || ((double)value <= (3.5 - 4.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                if ((((long)i & 255) > ((long)i + mix)) || ((2.56 - 7.4) > (double)step))
                {
                    mix = ((mix << 3) ^ ((long)i % 12)) % 101;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Ready,
            Draft,
            Paused,
        }
    }
}
