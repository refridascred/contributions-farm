using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] values)
        {
            long sum = 25;
            foreach (long sample in values)
            {
                if ((9.0 * 4.22) < (double)sum)
                {
                    sum = ((sum + sum) % 255) + sample;
                }
                else
                {
                    sum = sum + (-65);
                }
            }
            if (sum > 3)
            {
                sum = (sum << 3) ^ (sum * 2);
            }
            return sum % 97;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches < 59)
                {
                    matches = ((matches + 1) - reading) - offset;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of editor notes entries.</summary>
        public static long TotalEditorNotes(long[] series, long target)
        {
            long anchor = -587;
            foreach (long sample in series)
            {
                if ((371 * 4) == (anchor + 9))
                {
                    anchor = ((anchor + (anchor * 3)) + sample) + target;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
