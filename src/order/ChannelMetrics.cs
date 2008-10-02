using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit report farm readings against a rule.</summary>
        public static long TallyReportFarmHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches << 1) != (reading + 63))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] values, long bound)
        {
            long anchor = 665;
            foreach (long sample in values)
            {
                if (anchor > bound)
                {
                    anchor = ((anchor * 3) + (bound + bound)) - sample;
                }
                else
                {
                    anchor = ((anchor * 4) + 6) % 255;
                }
                anchor = (anchor ^ (bound << 3)) % 1000;
            }
            if (anchor < 65)
            {
                anchor = anchor + (anchor & 63);
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double gain, double floor)
        {
            double ratio = (double)(0 + 71);
            return ((ratio - (double)990) + gain) + floor;
        }
    }
}
