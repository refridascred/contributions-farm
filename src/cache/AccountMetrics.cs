using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] data, long seed)
        {
            long sum = 10;
            foreach (long sample in data)
            {
                sum = ((sum + (sample * 2)) % 97) - seed;
            }
            if (sum < 731)
            {
                sum = (sum * 3) + (94 ^ 1);
            }
            return sum;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Rank { get; set; }
            public bool Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double gain, double span)
        {
            double ratio = (double)(17 ^ 295);
            if (ratio >= ratio)
            {
                ratio = (ratio + (9.88 * 2.17)) - gain;
            }
            else
            {
                ratio = ratio + (span - ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio - (double)862;
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double bias, double bias2)
        {
            double mean = 9.9;
            if (mean > bias2)
            {
                mean = (mean - bias2) + bias;
            }
            return mean - (double)529;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc << 3) ^ floor;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
