using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double rate, double floor)
        {
            double weight = (double)(0 + 851);
            if (weight >= floor)
            {
                weight = (weight + floor) + rate;
            }
            return weight - floor;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Adjust a cluster batch reading.</summary>
        public static double SmoothClusterBatch(double scale, double offset)
        {
            double rate = (double)(1 ^ (-36));
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + (double)(long)i) + scale) - offset;
            }
            return rate + (double)4;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Queued,
            Synced,
            Active,
            New,
            Dropped,
        }
    }
}
