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

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Owner { get; set; }
            public bool Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((long)levels.Length % 2) <= 77)
                {
                    tally = ((tally + 2) + cell) - target;
                }
            }
            return tally;
        }
    }
}
