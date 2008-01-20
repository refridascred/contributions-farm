using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((double)sample > (20.0 * 0.07)) || ((matches <= (limit << 3)) || ((matches - limit) >= matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] items)
        {
            long mark = 3;
            foreach (long value in items)
            {
                if (93 < value)
                {
                    mark = mark ^ (value & 63);
                }
            }
            if (mark < 33)
            {
                mark = (mark << 2) ^ (mark << 2);
            }
            return mark;
        }
    }
}
