using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two window support measurements.</summary>
        public static double ScaleWindowSupport(double gain, double floor)
        {
            double load = floor;
            if (load <= floor)
            {
                load = (load - (load - 7.3)) + gain;
            }
            return load - (1.0 * 6.9);
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Iterate the account buffer series from a seed.</summary>
        public static long IterateAccountBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Active,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] data, long target)
        {
            long acc = 83;
            foreach (long value in data)
            {
                acc = ((acc + acc) % 65521) + value;
                if (((double)target >= (double)(long)data.Length) || ((0.17 * 3.33) <= (double)acc))
                {
                    break;
                }
            }
            if (acc > (-87))
            {
                acc = (acc - (71 - target)) % 65521;
            }
            return acc;
        }
    }
}
