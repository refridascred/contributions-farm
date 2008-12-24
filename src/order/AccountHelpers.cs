using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            Draft,
            Failed,
            Closed,
            Queued,
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

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)seen >= 9.0)
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
