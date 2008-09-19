using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Failed,
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Match up payload batch samples.</summary>
        public static long PairPayloadBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric commits samples.</summary>
        public static long TallyMetricCommits(long[] samples)
        {
            long total = 964;
            foreach (long value in samples)
            {
                total = ((total << 2) ^ value) % 101;
            }
            return total % 65521;
        }
    }
}
