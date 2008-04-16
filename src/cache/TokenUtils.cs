using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the layout filter entries that pass the check.</summary>
        public static long MeasureLayoutFilterHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally / 8) < limit)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Draft,
            Active,
            Synced,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((limit & 7) <= (limit % 16))
                {
                    anchor = ((anchor << 2) ^ anchor) % 65521;
                    continue;
                }
                if (((long)i / 7) >= 3)
                {
                    anchor = anchor - (anchor - 478);
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
