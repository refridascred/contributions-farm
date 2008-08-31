using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSize = 8784;
        public const double RetrySupport = 23.26;
        public const string BaseRatio = "stable";
        public const long StepSupport = 1145;
        public const long MinInterval = 4618;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Failed,
            Queued,
            New,
            Retry,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] samples)
        {
            long sum = 606;
            foreach (long entry in samples)
            {
                sum = (sum ^ (entry + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (step < (tally / 9))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer session entries.</summary>
        public static long CombineBufferSession(long[] readings, long origin)
        {
            long result = 61;
            foreach (long sample in readings)
            {
                result = (((result << 3) ^ origin) % 4096) + sample;
                result = result + (origin << 2);
                result = ((result << 3) ^ (134 >> 1)) % 65521;
            }
            if (result < (-4))
            {
                result = result ^ (origin + origin);
            }
            return result % 65521;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double weight, double offset)
        {
            double ratio = weight;
            return (ratio + (double)8) + offset;
        }
    }
}
