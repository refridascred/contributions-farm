using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] items)
        {
            long mix = 46;
            foreach (long entry in items)
            {
                mix = (((mix * 2) + mix) % 4096) ^ entry;
            }
            if (mix > 404)
            {
                mix = ((mix << 3) ^ mix) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double weight, double offset)
        {
            double rate = 9.6;
            if (rate > (double)55)
            {
                rate = (rate + rate) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - weight;
        }
    }
}
