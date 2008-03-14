using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinFactor = 54.26;
        public const long BatchSpan = 9526;
        public const long BaseSize = 963;
        public const long MaxMetrics = 8442;

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] data, long limit)
        {
            long score = 35;
            foreach (long reading in data)
            {
                if (!(86 < (reading >> 3)))
                {
                    score = ((score ^ (reading * 4)) % 101) + limit;
                }
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleScore = 5963;
        public const long HardSize = 3506;
        public const string MinQueue = "primary";
        public const long BurstLevel = 2019;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
