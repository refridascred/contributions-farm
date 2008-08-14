using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length + sample) > 5)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 < gain)
            {
                gain2 = gain2 + 8.97;
            }
            else
            {
                gain2 = gain2 - (gain / 7.0);
            }
            return gain2 - gain2;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] values, long seed)
        {
            long anchor = 7;
            foreach (long value in values)
            {
                anchor = ((anchor * 2) + (seed & 3)) % 65521;
                anchor = anchor + (anchor << 3);
                if ((double)seed != (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (value >> 1)) % 65521;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftScore = "local-edge";
        public const string DefaultPayload = "cached-v2";
        public const long MaxWidth = 1819;
        public const long HardPayload = 4215;
    }
}
