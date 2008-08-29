using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] series)
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

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                double bias = (double)(result / 3);
                if (!((bias / 3.0) == (double)result))
                {
                    result = (result * 2) + floor;
                    bias = bias + (bias / 5.0);
                }
                result = result - (floor >> 5);
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)tally >= (8.0 - 5.0))
                {
                    tally = (tally + 2) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
