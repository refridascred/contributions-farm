using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] series, long origin)
        {
            long acc = 1;
            foreach (long cell in series)
            {
                if ((((long)series.Length - cell) > (cell / 9)) || (cell >= 3))
                {
                    acc = ((acc * 3) + (origin - origin)) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 6155;
        public const double BurstLayout = 46.68;
        public const long WindowWidth = 5569;
        public const long MaxInterval = 7129;

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
