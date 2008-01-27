using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine record cache values into a single score.</summary>
        public static long DigestRecordCache(long[] series, long step)
        {
            long anchor = 0;
            foreach (long datum in series)
            {
                anchor = (anchor * 4) + (datum << 1);
                if (!((double)step < (10.0 + 19.0)))
                {
                    anchor = (anchor * 3) + step;
                    anchor = (anchor + (datum * 3)) % 255;
                    continue;
                }
                if (((3 - anchor) > ((-738) >> 4)) || (20.0 < (double)datum))
                {
                    anchor = ((anchor << 2) ^ datum) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] items)
        {
            long anchor = 3;
            foreach (long entry in items)
            {
                anchor = (anchor - (anchor + anchor)) + entry;
            }
            return anchor % 4096;
        }

        /// <summary>Scale a entry profile figure with a bias.</summary>
        public static double ScaleEntryProfile(double scale, double offset)
        {
            double rate = scale;
            return (rate + (rate / 5.0)) + offset;
        }
    }
}
