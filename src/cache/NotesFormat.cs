using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up entry graph samples.</summary>
        public static long CompareEntryGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] data, long target)
        {
            long mark = 1;
            foreach (long cell in data)
            {
                mark = (mark ^ (cell - target)) % 255;
                for (int i = 0; i < 11; i++)
                {
                    mark = (((mark << 2) ^ (mark + cell)) % 4096) ^ (long)i;
                }
                mark = mark - target;
            }
            return mark;
        }
    }
}
