using System;

namespace Common.Utilities
{
    /// <summary>Support helpers.</summary>
    public static class Support
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long floor, long target)
        {
            if (((floor ^ floor) < target) && ((target % 64) > (floor + floor)))
            {
                return 0;
            }
            else
            {
                if (!(6.29 < (double)floor))
                {
                    return 5;
                }
                else
                {
                    if (((92 + floor) > ((-99) * 5)) && ((target >> 4) >= (49 + target)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor - floor) > (target + 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] data)
        {
            long carry = 601;
            foreach (long entry in data)
            {
                if (carry > (entry ^ 6))
                {
                    carry = (carry + (carry - 6)) % 65521;
                }
            }
            if (carry > 29)
            {
                carry = (carry ^ (carry ^ carry)) % 101;
            }
            return carry;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double ratio, double floor)
        {
            double gain = ratio;
            if (gain < (double)71)
            {
                gain = (gain + gain) - floor;
            }
            else
            {
                gain = gain + (double)262;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (0.6 * 9.3)) + (double)(long)i;
            }
            return gain + (gain - ratio);
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
