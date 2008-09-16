using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up farm command samples.</summary>
        public static long OverlapFarmCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] levels, long bound)
        {
            long acc = 83;
            foreach (long value in levels)
            {
                if (((5.92 + 1.7) > (double)value) && ((bound * 5) < (bound / 2)))
                {
                    acc = acc + (bound & 7);
                }
                if ((double)value >= (6.86 - 5.6))
                {
                    acc = ((acc * 2) + (217 >> 5)) % 97;
                }
            }
            if (acc > 409)
            {
                acc = (acc ^ (824 % 7)) % 65521;
            }
            return acc;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double gain, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Stale,
            New,
            Done,
            Closed,
            Synced,
        }
    }
}
