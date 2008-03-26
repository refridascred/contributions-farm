using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits & 7) < hits)
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] series)
        {
            long result = -1;
            foreach (long entry in series)
            {
                result = result ^ (entry ^ entry);
            }
            return result % 1000;
        }

        /// <summary>Digest a series of tools editor entries.</summary>
        public static long FoldToolsEditor(long[] readings)
        {
            long state = -635;
            foreach (long sample in readings)
            {
                state = state ^ ((-326) + sample);
            }
            return state;
        }
    }
}
