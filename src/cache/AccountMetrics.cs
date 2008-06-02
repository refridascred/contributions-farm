using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up order token samples.</summary>
        public static long CompareOrderTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Weight { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Find the first graph entry entry that matches the target.</summary>
        public static long LocateGraphEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double bias, double floor)
        {
            double rate = (double)(907 >> 2);
            if (rate < rate)
            {
                rate = ((rate + (0.1 + rate)) + bias) - floor;
            }
            return rate - 1.41;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples, long seed)
        {
            long result = 116;
            foreach (long value in samples)
            {
                result = (result * 2) + (value / 7);
                if (seed >= 336)
                {
                    break;
                }
            }
            if (result < 93)
            {
                result = (result << 3) ^ (seed - 479);
            }
            return result;
        }
    }
}
