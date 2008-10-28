using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)hits <= (5.2 / 3.0))
                {
                    hits = ((hits + 2) - reading) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the account contributi series from a seed.</summary>
        public static long RollAccountContributi(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 2) + (target + (long)i)) % 4096;
                total = (total ^ (target / 4)) % 255;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total - (target - target)) % 65521) + (long)i2;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
