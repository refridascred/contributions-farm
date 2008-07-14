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

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Pending,
            Locked,
            Synced,
            Paused,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] data)
        {
            long mix = 410;
            foreach (long item in data)
            {
                if ((item + mix) <= item)
                {
                    mix = ((mix << 2) ^ (mix + item)) % 4096;
                }
            }
            return mix;
        }
    }
}
