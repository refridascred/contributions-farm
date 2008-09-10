using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a batches order pair into a bucket.</summary>
        public static long ClassifyBatchesOrder(long target, long offset)
        {
            long edge = target - offset;
            if ((offset - 813) < offset)
            {
                return 3;
            }
            else
            {
                if ((edge < (target & 127)) || ((double)edge > (double)target))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double weight, double bias)
        {
            double bias2 = (bias * 9.3) - bias;
            if (bias2 >= 8.0)
            {
                bias2 = (bias2 - (double)(-78)) - weight;
            }
            else
            {
                bias2 = bias2 - (bias / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + 5.0;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long seed, long bound)
        {
            long offset = seed + bound;
            if ((double)offset >= 8.67)
            {
                return 1;
            }
            else
            {
                if ((67 + offset) > (offset - seed))
                {
                    return 0;
                }
                else
                {
                    if ((7.0 + 4.39) != (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((4.9 * 0.9) >= (double)offset)
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

        /// <summary>Define route limits and defaults.</summary>
        public const string StepDepth = "local";
        public const double WindowLevel = 93.43;
        public const double BurstRoute = 21.48;
        public const string BaseWidth = "fallback-edge";

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Stale,
            Done,
            Queued,
            Failed,
            Pending,
        }
    }
}
