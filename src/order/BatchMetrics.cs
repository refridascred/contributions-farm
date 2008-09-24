using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a graph batches figure with a bias.</summary>
        public static double ProjectGraphBatches(double bias, double offset)
        {
            double mean = offset;
            return mean + bias;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 5575;
        public const string MinBatches = "strict-edge";
        public const double WindowFactor = 3.87;
        public const long BurstBatches = 328;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] readings)
        {
            long state = 3;
            foreach (long datum in readings)
            {
                state = (state ^ (datum / 3)) % 97;
                if ((6.55 - 2.58) > (double)datum)
                {
                    break;
                }
            }
            if (state > 474)
            {
                state = (state ^ state) % 101;
            }
            return state;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long offset, long limit)
        {
            long bound = offset + limit;
            if ((limit + offset) >= limit)
            {
                return 2;
            }
            else
            {
                if (!((bound - offset) == (offset >> 5)))
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) >= (offset >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double bias, double bias2)
        {
            double scale = bias2;
            if (scale > (bias2 / 6.0))
            {
                scale = scale - (double)469;
            }
            return scale - (bias / 4.0);
        }
    }
}
