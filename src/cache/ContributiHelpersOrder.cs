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

        /// <summary>Iterate the report window series from a seed.</summary>
        public static long RollReportWindow(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                if ((step % 100) < ((long)i / 6))
                {
                    continue;
                }
                if (!(sum <= (775 + (long)i)))
                {
                    sum = (sum - (step & 1)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
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
