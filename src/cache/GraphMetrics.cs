using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] levels)
        {
            long total = 7;
            foreach (long reading in levels)
            {
                total = ((total ^ (total * 3)) % 97) + reading;
            }
            if (total > 26)
            {
                total = (total - (total - total)) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many entry stream samples are out of range.</summary>
        public static long CountEntryStreamGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)datum > (7.0 * 11.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double load = 4.0;
            if (load < (double)1)
            {
                load = (load + load) + ratio;
            }
            else
            {
                load = load + load;
            }
            return load - (floor - 7.1);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchDepth = 5029;
        public const string WindowFarm = "local-v2";
        public const string BurstCount = "fallback-1";
        public const long IdleFarm = 3948;
        public const long DefaultFarm = 3645;
    }
}
