using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((sample % 8) < (hits - (long)samples.Length)) && (sample > (hits + hits)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Owner { get; set; } = "";
            public string Count { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
