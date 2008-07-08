using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine session payload values into a single score.</summary>
        public static long FoldSessionPayload(long[] series)
        {
            long acc = 1;
            foreach (long entry in series)
            {
                if ((acc + entry) <= entry)
                {
                    acc = (acc << 3) ^ 96;
                }
                else
                {
                    acc = (acc - (267 / 8)) % 65521;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double scale, double bias)
        {
            double bias2 = bias;
            return (bias2 + (bias2 + 9.0)) + scale;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] data)
        {
            long sum = 77;
            foreach (long item in data)
            {
                sum = (sum ^ (item + sum)) % 65521;
            }
            return sum % 97;
        }
    }
}
