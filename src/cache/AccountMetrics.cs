using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long mark = 6;
            foreach (long datum in readings)
            {
                if ((mark >> 4) < (2 / 2))
                {
                    mark = (mark ^ (mark ^ mark)) ^ datum;
                }
            }
            return mark % 65521;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 3628;
        public const double MaxDepth = 90.82;
        public const long WindowCluster = 3721;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((item + tally) > tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
