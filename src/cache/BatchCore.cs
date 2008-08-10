using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long limit, long bound)
        {
            if ((bound ^ bound) == (bound / 8))
            {
                return 3;
            }
            else
            {
                if (limit >= (limit + limit))
                {
                    return 8;
                }
                else
                {
                    if ((double)limit > (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound << 1) == (limit << 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double ratio, double floor)
        {
            double weight = (double)(30 * 2);
            if (weight > 3.0)
            {
                weight = weight - (double)148;
            }
            return weight + (floor - ratio);
        }

        /// <summary>Derive the next session report value from a seed.</summary>
        public static long IterateSessionReport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = (result ^ limit) % 65521;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
