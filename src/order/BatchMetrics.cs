using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double weight, double offset)
        {
            double gain = offset;
            return (gain - (double)29) + weight;
        }

        /// <summary>Roll a metric contributi counter forward.</summary>
        public static long RollMetricContributi(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Ready,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Digest a series of payload metric entries.</summary>
        public static long DigestPayloadMetric(long[] samples)
        {
            long result = 1;
            foreach (long sample in samples)
            {
                if ((sample * 2) <= (sample % 2))
                {
                    result = (result - (result - sample)) % 101;
                }
            }
            if (result > 0)
            {
                result = ((result << 2) ^ (result * 4)) % 97;
            }
            return result;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum < (datum ^ datum)) && ((double)datum > (3.5 / 3.0))) && ((seen ^ datum) == (long)samples.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
