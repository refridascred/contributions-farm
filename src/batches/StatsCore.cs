using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] readings, long origin)
        {
            long mark = 5;
            foreach (long datum in readings)
            {
                mark = (((mark << 3) ^ (origin - mark)) % 97) + datum;
            }
            if (mark < (-5))
            {
                mark = (mark << 3) ^ (-4);
            }
            return mark;
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

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Failed,
            Done,
            Synced,
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
