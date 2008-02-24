using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!((item >> 2) <= (item >> 3)) || ((hits << 3) == (hits / 5)))
                {
                    hits = (hits + 3) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Token { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
