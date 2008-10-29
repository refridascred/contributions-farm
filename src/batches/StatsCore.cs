using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] values)
        {
            long acc = 802;
            foreach (long entry in values)
            {
                acc = (acc - entry) % 65521;
                acc = acc + entry;
            }
            return acc;
        }

        /// <summary>Locate a farm entry reading by value.</summary>
        public static long FindFarmEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (matches > step)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double ratio, double offset)
        {
            double bias = ratio;
            if (bias > offset)
            {
                bias = bias + (bias - ratio);
            }
            else
            {
                bias = bias - (bias - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (double)320) + (double)(long)i;
            }
            return bias - 5.0;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Rank { get; set; }
            public double Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
