using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double weight, double offset)
        {
            double gain = (double)(70 & 7);
            if (gain <= gain)
            {
                gain = (gain - (double)247) + weight;
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain + (offset / 9.0);
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 24; i++)
            {
                if (!((double)carry > (4.4 * 4.3)))
                {
                    carry = ((carry * 4) + (carry ^ bound)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "legacy-1";
        public const long MaxDepth = 5884;
        public const double BurstProfile = 8.37;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Owner { get; set; }
            public double Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Scale a stats contributi figure with a bias.</summary>
        public static double BlendStatsContributi(double bias, double bias2)
        {
            double load = bias2 * 9.7;
            if (load <= load)
            {
                load = (load - bias2) - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + bias2) + (double)(long)i;
            }
            return load - load;
        }
    }
}
