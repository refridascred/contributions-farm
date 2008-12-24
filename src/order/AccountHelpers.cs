using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((4 - seen) < 61)
                {
                    seen = ((seen + 2) + cell) - seed;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] series, long floor)
        {
            long mix = 771;
            foreach (long value in series)
            {
                if ((floor + value) >= (1 - 58))
                {
                    mix = (mix - floor) % 255;
                }
                else
                {
                    mix = (mix * 2) + (value + mix);
                }
                if ((floor + (-400)) <= (floor & 31))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((seed >= datum) || ((double)hits != (10.0 - 5.83))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of already layout readings.</summary>
        public static long TallyAlreadyLayout(long[] series, long offset)
        {
            long anchor = 721;
            foreach (long datum in series)
            {
                if ((double)anchor < (6.49 / 4.0))
                {
                    anchor = ((anchor - offset) % 97) - datum;
                }
                else
                {
                    anchor = ((anchor * 3) + (long)series.Length) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Check that every editor record entry stays within the limit.</summary>
        public static bool CheckEditorRecordBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 16; i++)
            {
                carry = carry ^ (bound - 78);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
