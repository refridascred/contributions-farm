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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits < target) && (((cell >> 3) > 80) && ((cell & 63) <= (cell + cell))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count - 6) < (value + (-81)))
                {
                    count = (count + 2) + origin;
                }
            }
            return count;
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
