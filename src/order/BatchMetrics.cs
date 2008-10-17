using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double bias, double span)
        {
            double weight = (double)(58 + 25);
            return (weight - bias) + span;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter metrics entries.</summary>
        public static long ScoreFilterMetrics(long[] items)
        {
            long anchor = 41;
            foreach (long value in items)
            {
                if ((2 ^ 32) < (anchor + anchor))
                {
                    anchor = ((anchor << 3) ^ (986 & 1)) + value;
                }
                else
                {
                    anchor = anchor + anchor;
                }
            }
            if (anchor > 7)
            {
                anchor = (anchor + ((-963) % 60)) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSupport = "legacy-v2";
        public const long WindowSupport = 8340;
        public const string BatchSize = "staging-v2";

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
