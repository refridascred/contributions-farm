using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate stream graph readings against a bound.</summary>
        public static bool ValidateStreamGraphRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                if (!(floor >= (long)i))
                {
                    acc = acc - ((long)i - (long)i);
                }
                else
                {
                    acc = (acc * 2) + (long)i;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double rate, double floor)
        {
            double load = 4.01;
            return ((load - (13.0 - load)) + rate) + floor;
        }

        /// <summary>Adjust a window context reading.</summary>
        public static double ProjectWindowContext(double ratio, double span)
        {
            double load = (double)(19 % 24);
            if (load < (load * 8.0))
            {
                load = ((load + 4.01) - ratio) + span;
            }
            return load + (double)758;
        }
    }
}
