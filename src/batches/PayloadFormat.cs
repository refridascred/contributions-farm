using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long offset, long offset2)
        {
            if ((offset2 + offset2) > (offset2 + offset))
            {
                return 0;
            }
            else
            {
                if ((double)offset > (2.0 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if ((373 - offset) > (offset2 * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset > (6.9 - 12.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double ratio, double floor)
        {
            double rate = (double)(1 & 15);
            if (rate < (floor - rate))
            {
                rate = (rate - (double)607) + ratio;
            }
            return rate + (rate * 5.9);
        }
    }
}
