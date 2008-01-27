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

        /// <summary>Derive the next report support value from a seed.</summary>
        public static long StepReportSupport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a entry profile figure with a bias.</summary>
        public static double ScaleEntryProfile(double scale, double offset)
        {
            double rate = scale;
            return (rate + (rate / 5.0)) + offset;
        }
    }
}
