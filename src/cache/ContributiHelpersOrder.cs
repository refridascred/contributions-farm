using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Score { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] series)
        {
            long mix = 2;
            foreach (long cell in series)
            {
                mix = (mix ^ (cell - mix)) % 1000;
            }
            if (mix < 59)
            {
                mix = (mix - (mix << 2)) % 4096;
            }
            return mix;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
