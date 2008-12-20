using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = acc ^ acc;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Idle,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate context metric readings against a bound.</summary>
        public static bool CheckContextMetricRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double gain, double bias)
        {
            double rate = 8.1;
            if (rate >= bias)
            {
                rate = rate - 9.0;
            }
            else
            {
                rate = rate - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - bias) - (double)(long)i;
            }
            return rate + 8.93;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
