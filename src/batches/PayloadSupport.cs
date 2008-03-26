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

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] data)
        {
            long mark = 8;
            foreach (long reading in data)
            {
                mark = (mark + reading) % 1000;
            }
            if (mark > 13)
            {
                mark = ((mark << 3) ^ (long)data.Length) % 65521;
            }
            return mark;
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
