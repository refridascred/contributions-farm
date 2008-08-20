using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of report cache readings.</summary>
        public static long OverlapReportCacheCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next command farm value from a seed.</summary>
        public static long IterateCommandFarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor + (anchor - (-547))) % 101;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = (anchor ^ (long)i) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double ratio, double bias)
        {
            double drift = (double)(7 + 6);
            if (drift > (bias - drift))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + ratio;
            }
            return drift + (double)(-51);
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
