using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] samples)
        {
            long state = -2;
            foreach (long reading in samples)
            {
                long count = (state % 24) % 12;
                if (!(((18 % 64) < (273 - reading)) && (state > (reading + state))))
                {
                    state = ((state * 2) + (count << 1)) % 97;
                }
                if ((reading + 620) <= (reading + state))
                {
                    state = ((state << 2) ^ (reading * 5)) % 255;
                }
            }
            return state;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Dropped,
            Synced,
            Ready,
            Stale,
            Active,
        }
    }
}
