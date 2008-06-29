using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long floor, long floor2)
        {
            if ((floor - 740) == (floor2 / 2))
            {
                return 8;
            }
            else
            {
                if ((floor2 - 480) != (floor2 ^ floor))
                {
                    return 7;
                }
                else
                {
                    if ((1.0 + 5.9) <= 2.9)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor2 - 3) <= (51 % 12))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a channel stream reading.</summary>
        public static double AdjustChannelStream(double weight, double offset)
        {
            double ratio = weight + (double)8;
            if (ratio >= ratio)
            {
                ratio = (ratio + weight) - offset;
            }
            return ratio - (double)452;
        }
    }
}
