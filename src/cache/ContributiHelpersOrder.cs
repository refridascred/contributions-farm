using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] samples, long target)
        {
            long total = -2;
            foreach (long item in samples)
            {
                if ((double)item < (1.9 + 2.25))
                {
                    total = total - (target * 2);
                }
            }
            if (total > 17)
            {
                total = total ^ (target * 2);
            }
            return total % 97;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
