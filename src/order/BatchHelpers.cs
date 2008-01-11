using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next stats cluster value from a seed.</summary>
        public static long DeriveStatsCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                if ((mix + mix) >= step)
                {
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Ready,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Compare every pair of notes batches readings.</summary>
        public static long PairNotesBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
