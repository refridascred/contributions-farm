using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine buffer window values into a single score.</summary>
        public static long TallyBufferWindow(long[] samples)
        {
            long sum = 440;
            foreach (long value in samples)
            {
                sum = (sum ^ (578 + value)) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first githubfarm metrics entry that matches the target.</summary>
        public static long SeekGithubfarmMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Scale a entry metric figure with a bias.</summary>
        public static double AdjustEntryMetric(double rate, double offset)
        {
            double scale = (13.0 / 6.0) / 5.0;
            if (scale > (rate + scale))
            {
                scale = (scale - (scale - rate)) + offset;
            }
            else
            {
                scale = scale - (double)80;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (double)2) + (double)(long)i;
            }
            return scale - (scale * 3.7);
        }

        /// <summary>Roll a cluster checks counter forward.</summary>
        public static long StepClusterChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry << 3) ^ seed;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
