using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of context farm entries.</summary>
        public static long DigestContextFarm(long[] samples, long bound)
        {
            long mix = 64;
            foreach (long reading in samples)
            {
                if ((double)bound == (double)mix)
                {
                    mix = mix + (reading << 1);
                }
            }
            return mix;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            Active,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry + (long)readings.Length) >= entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate account queue samples.</summary>
        public static long WeighAccountQueue(long[] data)
        {
            long sum = 25;
            foreach (long sample in data)
            {
                sum = (sum * 5) + (sum << 2);
                if (!((sum - (-8)) == (sum >> 4)))
                {
                    sum = ((sum << 3) ^ (sample + 83)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Limit { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
