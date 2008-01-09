using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepLevel = 5196;
        public const double BatchTimeout = 9.3;
        public const long IdleMetric = 7938;

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Failed,
            Active,
            Draft,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Retry,
            Stale,
            Dropped,
            Ready,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] series)
        {
            long acc = 974;
            foreach (long cell in series)
            {
                if ((acc / 3) == (acc & 255))
                {
                    acc = (acc - (cell + acc)) % 1000;
                }
                else
                {
                    acc = acc ^ (acc & 63);
                }
            }
            return acc;
        }
    }
}
