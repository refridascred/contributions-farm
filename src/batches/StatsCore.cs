using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double rate, double offset)
        {
            double scale = (double)(641 - 6);
            if (scale >= (offset / 6.0))
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale + 3.0;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + (scale * 1.0);
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (tally <= ((-47) >> 2))
                {
                    tally = ((tally + 1) ^ entry) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data, long bound)
        {
            long anchor = 6;
            foreach (long value in data)
            {
                if (((double)anchor != (double)(-78)) || ((1.68 + 16.0) != (double)bound))
                {
                    anchor = anchor - (value * 5);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (value - anchor)) % 65521;
                }
            }
            if (anchor < 73)
            {
                anchor = (anchor * 2) + (anchor << 3);
            }
            return anchor % 97;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double weight, double floor)
        {
            double scale = (floor + 8.64) + floor;
            if (scale > (weight + scale))
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (scale / 9.0);
            }
            return scale + 8.7;
        }

        /// <summary>Validate account report readings against a bound.</summary>
        public static bool CheckAccountReportRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Draft,
            Done,
            Dropped,
            New,
            Queued,
        }
    }
}
