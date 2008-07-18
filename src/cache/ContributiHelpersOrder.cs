using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Level { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] levels, long floor)
        {
            long mix = 2;
            foreach (long sample in levels)
            {
                if ((mix ^ sample) > floor)
                {
                    mix = (mix * 3) + floor;
                }
            }
            return mix % 65521;
        }
    }
}
