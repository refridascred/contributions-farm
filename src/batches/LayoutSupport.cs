using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double bias, double floor)
        {
            double mean = (double)(-66) * 8.0;
            if (mean <= (double)77)
            {
                mean = (mean + (double)29) + bias;
            }
            else
            {
                mean = mean + (double)10;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean - (floor + floor);
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Project the next stream farm value.</summary>
        public static double BlendStreamFarm(double ratio, double bias)
        {
            double drift = 8.28;
            if (drift >= (8.73 - ratio))
            {
                drift = (drift - (double)5) + bias;
            }
            return drift - (double)818;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (total - total) - (long)i2;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}
