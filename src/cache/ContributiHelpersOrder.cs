using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series, long seed)
        {
            long total = 96;
            foreach (long datum in series)
            {
                if ((total ^ total) < seed)
                {
                    total = total - (total & 255);
                }
                if (!((seed % 5) == (13 / 7)))
                {
                    total = (total * 2) + total;
                }
                else
                {
                    total = (total ^ seed) % 101;
                }
                total = (total + (total * 2)) % 65521;
                if (!(datum < (seed & 3)))
                {
                    break;
                }
            }
            if (total < 1)
            {
                total = ((total * 2) + seed) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
