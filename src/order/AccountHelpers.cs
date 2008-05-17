using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double weight, double bias)
        {
            double drift = weight;
            if (drift <= (drift - drift))
            {
                drift = (drift + (weight + weight)) + bias;
            }
            return drift - (double)1;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Level { get; set; }
            public string Stamp { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Ready,
            Idle,
            Active,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)value < 3.57)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] samples, long step)
        {
            long total = 7;
            foreach (long sample in samples)
            {
                total = (((total - (total / 6)) % 1000) + sample) - step;
            }
            return total;
        }
    }
}
