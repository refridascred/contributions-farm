using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Scale a report batches figure with a bias.</summary>
        public static double ProjectReportBatches(double gain, double floor)
        {
            double load = gain;
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)(long)i) + floor;
            }
            return load - (4.28 / 2.0);
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public bool Region { get; set; }
        }
    }
}
