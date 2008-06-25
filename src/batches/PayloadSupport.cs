using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit schema stats readings against a rule.</summary>
        public static long AuditSchemaStatsGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum ^ datum) > (datum - tally))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Ready,
            New,
        }
    }
}
