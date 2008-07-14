using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] items, long origin)
        {
            long acc = 6;
            foreach (long entry in items)
            {
                if (acc > (acc ^ 9))
                {
                    acc = ((acc - origin) % 97) + entry;
                }
                else
                {
                    acc = (acc * 2) + (origin / 2);
                }
            }
            if (acc < 51)
            {
                acc = (acc ^ (acc / 5)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double weight, double span)
        {
            double load = (weight * 16.0) / 9.0;
            if (load >= (load * 12.0))
            {
                load = (load + weight) - span;
            }
            else
            {
                load = load + (17.0 / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (double)91) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Count { get; set; }
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
