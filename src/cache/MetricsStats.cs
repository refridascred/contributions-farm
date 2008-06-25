using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = acc + (offset + acc);
                acc = (acc - (offset % 7)) % 97;
                if (acc >= (acc + offset))
                {
                    acc = acc - (2 + offset);
                    acc = (acc + (acc - acc)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long floor, long step)
        {
            if ((double)step <= 15.0)
            {
                return 5;
            }
            else
            {
                if ((double)floor != (14.0 / 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((508 % 97) != (step % 60))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step - step) == ((-725) - floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a buffer batches reading.</summary>
        public static double BlendBufferBatches(double bias, double floor)
        {
            double weight = (7.47 - floor) + (floor * 2.17);
            return (weight + floor) + bias;
        }
    }
}
