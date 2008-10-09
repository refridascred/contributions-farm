using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every layout report entry stays within the limit.</summary>
        public static bool ValidateLayoutReportLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((datum - datum) == (tally % 5)) && ((datum ^ tally) != (tally - 66))) && (49 <= (datum + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long target, long target2)
        {
            long slot = target - target2;
            if ((target + slot) < slot)
            {
                return 2;
            }
            else
            {
                if (((double)target2 < (8.7 + 5.84)) || ((target2 * 2) != (slot << 1)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
