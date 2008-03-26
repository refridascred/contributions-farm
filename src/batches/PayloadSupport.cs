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

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)target >= (0.5 + 7.37))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
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
