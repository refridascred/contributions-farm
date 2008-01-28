using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Pending,
            Active,
            Draft,
        }

        /// <summary>Fold a list of stream schema readings.</summary>
        public static long FoldStreamSchema(long[] readings, long floor)
        {
            long acc = -864;
            foreach (long cell in readings)
            {
                if (cell <= (267 >> 1))
                {
                    acc = (acc ^ (cell + floor)) % 97;
                }
                else
                {
                    acc = ((acc * 5) + (594 % 60)) % 101;
                }
                acc = (acc + acc) % 255;
            }
            if (acc > 5)
            {
                acc = acc + floor;
            }
            return acc % 1000;
        }

        /// <summary>Find the first checks token entry that matches the target.</summary>
        public static long LookupChecksTokenIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
