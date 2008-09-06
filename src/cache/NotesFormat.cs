using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] readings, long bound)
        {
            long anchor = 1;
            foreach (long datum in readings)
            {
                if ((anchor - datum) != (datum * 2))
                {
                    anchor = ((anchor * 3) + 3) % 1000;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor << 3) ^ (bound + bound);
            }
            return anchor;
        }

        /// <summary>Iterate the checks filter series from a seed.</summary>
        public static long StepChecksFilter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor << 3) ^ (long)i;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] readings)
        {
            long mix = 8;
            foreach (long cell in readings)
            {
                mix = ((mix * 2) + (cell + 46)) % 97;
                if ((mix - mix) >= (554 - cell))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
