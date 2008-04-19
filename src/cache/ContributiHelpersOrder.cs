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

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "standard-edge";
        public const long SoftInterval = 4273;
        public const long WindowCommand = 4469;
        public const long WindowLevel = 3332;
    }
}
