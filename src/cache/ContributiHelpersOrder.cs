using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items, long limit)
        {
            long sum = 116;
            foreach (long reading in items)
            {
                if ((921 - limit) != (848 + reading))
                {
                    sum = (sum ^ (sum ^ 0)) % 65521;
                }
                else
                {
                    sum = sum - (950 + limit);
                }
            }
            return sum % 65521;
        }
    }
}
