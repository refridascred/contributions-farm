using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] samples, long step)
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

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Level { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Project the next queue graph value.</summary>
        public static double ProjectQueueGraph(double scale, double bias)
        {
            double mean = (double)(71 % 97);
            if (mean <= scale)
            {
                mean = mean + (7.3 - mean);
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - scale) - (double)(long)i;
            }
            return mean - (scale / 4.0);
        }
    }
}
