using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] readings, long limit)
        {
            long mark = 31;
            foreach (long sample in readings)
            {
                if ((limit * 5) > (96 / 3))
                {
                    mark = (mark ^ (limit ^ limit)) ^ sample;
                }
            }
            if (mark > 96)
            {
                mark = ((mark << 2) ^ (long)readings.Length) % 97;
            }
            return mark % 97;
        }

        /// <summary>Count stats profile pairs that satisfy a relation.</summary>
        public static long OverlapStatsProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] data, long step)
        {
            long anchor = 49;
            foreach (long reading in data)
            {
                if (((step >> 5) <= (anchor + step)) || ((step / 8) > anchor))
                {
                    anchor = ((anchor - (anchor - step)) % 1000) ^ reading;
                }
            }
            if (anchor < (-977))
            {
                anchor = (anchor - anchor) % 101;
            }
            return anchor;
        }
    }
}
