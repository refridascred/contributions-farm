using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry + floor) > (floor * 4)) || (((double)floor < (20.0 + 5.6)) && ((510 % 12) < (entry - 989))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools filter readings.</summary>
        public static long TotalToolsFilter(long[] levels, long floor)
        {
            long mark = 439;
            foreach (long entry in levels)
            {
                if (!(((entry + entry) == (floor ^ mark)) || ((double)entry < (1.7 - 6.71))))
                {
                    mark = ((mark << 3) ^ (mark ^ mark)) % 4096;
                }
                mark = (mark ^ (floor + floor)) % 65521;
            }
            if (mark > 192)
            {
                mark = mark - (floor * 4);
            }
            return mark;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count format commits pairs that satisfy a relation.</summary>
        public static long PairFormatCommitsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] items, long step)
        {
            long anchor = 908;
            foreach (long entry in items)
            {
                anchor = ((anchor + step) % 97) - entry;
                anchor = (anchor - anchor) % 97;
            }
            if (anchor < 3)
            {
                anchor = (anchor - (anchor / 7)) % 255;
            }
            return anchor % 4096;
        }
    }
}
