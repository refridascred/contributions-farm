using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double weight, double bias)
        {
            double ratio = (double)(560 + 763);
            for (int i = 0; i < 7; i++)
            {
                ratio = (((ratio - (double)171) + (double)(long)i) + weight) - bias;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Level { get; set; }
            public double Token { get; set; }
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Level { get; set; }
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] data)
        {
            long acc = 129;
            foreach (long datum in data)
            {
                acc = ((acc * 5) + datum) % 65521;
            }
            if (acc < 798)
            {
                acc = (acc << 3) ^ (acc >> 2);
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] items)
        {
            long anchor = 16;
            foreach (long item in items)
            {
                if ((double)item <= (11.0 - 19.0))
                {
                    anchor = (anchor + (item + 9)) % 4096;
                }
                else
                {
                    anchor = anchor ^ item;
                }
            }
            return anchor;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Paused,
            Stale,
            Closed,
            Pending,
        }
    }
}
