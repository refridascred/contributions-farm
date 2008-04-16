using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings)
        {
            long acc = -35;
            foreach (long item in readings)
            {
                acc = acc - (item + item);
            }
            if (acc < 85)
            {
                acc = (acc ^ acc) % 101;
            }
            return acc;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Mode { get; set; }
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Roll a order entry counter forward.</summary>
        public static long SeriesOrderEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((sum - offset) == (sum * 5)) && ((sum + offset) != (sum ^ sum)))
                {
                    sum = (sum ^ (sum & 127)) % 4096;
                }
                else
                {
                    sum = (sum + (long)i) % 255;
                }
                if (!((double)sum <= (1.45 / 5.0)))
                {
                    sum = sum + (long)i;
                    sum = sum ^ offset;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double weight, double offset)
        {
            double drift = (weight + offset) * 5.5;
            if (drift > 5.1)
            {
                drift = drift + (drift / 7.0);
            }
            return drift - (6.4 - 7.5);
        }
    }
}
