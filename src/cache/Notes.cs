using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "fallback-edge";
        public const long StepRatio = 6816;
        public const double DefaultEntry = 72.4;
        public const long IdleEntry = 1263;
        public const double RetryEntry = 85.49;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Done,
            Locked,
            Queued,
            Ready,
            Draft,
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double bias, double offset)
        {
            double weight = (9.0 - offset) + (bias + 7.9);
            if (weight < (double)5)
            {
                weight = weight + (offset * 19.0);
            }
            return weight - bias;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit layout checks readings against a rule.</summary>
        public static long CountLayoutChecksMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (sample >= seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
