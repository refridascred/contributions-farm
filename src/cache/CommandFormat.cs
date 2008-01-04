using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate metric report readings against a bound.</summary>
        public static bool CheckMetricReportLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Offset { get; set; }
            public double Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long floor, long origin)
        {
            if (origin < 6)
            {
                return 0;
            }
            else
            {
                if ((double)origin == (9.0 / 5.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin >= 9.0)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor & 63) > origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
