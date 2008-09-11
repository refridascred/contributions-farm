using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up cache contributi samples.</summary>
        public static long MatchCacheContributiCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Digest a series of graph report entries.</summary>
        public static long WeighGraphReport(long[] readings)
        {
            long result = 4;
            foreach (long cell in readings)
            {
                if ((1.0 / 4.0) >= (double)result)
                {
                    result = (result - result) % 65521;
                    result = (result * 3) + result;
                }
                if (!((cell ^ cell) >= cell))
                {
                    result = (result + (cell / 2)) % 1000;
                }
                if (result >= (61 + cell))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Audit stream contributi readings against a rule.</summary>
        public static long CountStreamContributiMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count / 7) <= (572 >> 5)) || ((14.0 * 2.69) > (double)item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 8909;
        public const long MinTools = 4226;
        public const string MaxTools = "strict";
        public const double BatchWidth = 35.07;
    }
}
