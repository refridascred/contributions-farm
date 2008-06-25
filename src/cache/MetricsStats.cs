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

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseSpan = 2733;
        public const string StepFarm = "legacy-v2";
        public const long BaseFarm = 4654;
        public const double HardFarm = 2.42;
        public const long SoftLevel = 4797;

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
