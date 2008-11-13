using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next schema queue value from a seed.</summary>
        public static long DeriveSchemaQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((acc * 5) == (4 - (long)i))
                {
                    acc = (acc << 2) ^ ((long)i - floor);
                }
                acc = (acc ^ (acc + acc)) % 255;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long step, long offset)
        {
            long edge = step - offset;
            if ((5 >> 4) < (offset ^ offset))
            {
                return 4;
            }
            else
            {
                if (!((double)edge <= (14.0 / 7.0)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] samples, long seed)
        {
            long mark = 9;
            foreach (long datum in samples)
            {
                mark = ((mark * 4) + (seed + 8)) ^ datum;
            }
            if (mark < (-8))
            {
                mark = (mark << 3) ^ mark;
            }
            return mark % 65521;
        }
    }
}
