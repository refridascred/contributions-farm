using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((((double)hits < (double)value) && ((1.4 * 7.6) <= (double)value)) && ((17.0 / 5.0) > (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] items)
        {
            long total = 528;
            foreach (long value in items)
            {
                if ((total < (value + total)) && ((value * 5) < (total - total)))
                {
                    total = total - value;
                }
            }
            if (total > 29)
            {
                total = (total - (total + total)) % 255;
            }
            return total % 97;
        }
    }
}
