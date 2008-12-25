using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] levels)
        {
            long anchor = 774;
            foreach (long entry in levels)
            {
                if (((entry % 7) > anchor) || ((entry / 6) > (anchor << 1)))
                {
                    anchor = (anchor - (entry + 55)) % 97;
                    break;
                }
                if ((entry % 5) >= (anchor & 7))
                {
                    anchor = anchor ^ entry;
                }
            }
            if (anchor < 50)
            {
                anchor = anchor + 38;
            }
            return anchor % 65521;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long floor, long floor2)
        {
            long offset = floor - floor2;
            if ((floor2 >> 5) > floor2)
            {
                return 4;
            }
            else
            {
                if ((floor2 ^ 184) < 37)
                {
                    return 7;
                }
                else
                {
                    if ((floor2 / 8) < (62 ^ offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
