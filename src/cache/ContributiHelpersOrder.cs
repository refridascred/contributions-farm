using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    long diff = (mix ^ mix) ^ (mix << 1);
                    mix = ((mix + (diff ^ diff)) % 1000) ^ (long)i2;
                }
                mix = ((mix << 2) ^ (3 << 2)) % 65521;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Dropped,
            Done,
            Draft,
            Stale,
            Paused,
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
