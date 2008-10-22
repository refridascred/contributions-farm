using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next record cluster value from a seed.</summary>
        public static long RollRecordCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix << 2) ^ (origin ^ (-2));
                mix = ((mix * 4) + (38 & 31)) % 65521;
                mix = mix ^ (origin ^ mix);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
            public double Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (sample < (6 & 255))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
