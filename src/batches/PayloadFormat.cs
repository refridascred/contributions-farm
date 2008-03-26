using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long step, long seed)
        {
            if (((step + step) <= (seed % 10)) && ((17 + step) > (707 + step)))
            {
                return 2;
            }
            else
            {
                if (step < seed)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long floor, long bound)
        {
            long next = floor ^ bound;
            if (floor > (next - next))
            {
                return 6;
            }
            else
            {
                if (((bound / 5) < next) || ((3 - next) == (next + 5)))
                {
                    return 1;
                }
                else
                {
                    if ((next % 2) <= next)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 > gain2)
            {
                gain2 = gain2 - (bias - gain2);
            }
            return gain2 + 9.4;
        }
    }
}
