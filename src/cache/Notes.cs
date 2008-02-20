using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Idle,
            Dropped,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double rate, double span)
        {
            double gain = rate - span;
            if (gain <= (13.0 / 7.0))
            {
                gain = gain + (double)814;
            }
            return gain - span;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double ratio, double span)
        {
            double gain = ratio;
            if (gain <= span)
            {
                gain = gain - (ratio + gain);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (5.0 + gain)) + (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((7.0 - 2.8) >= (double)reading)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
