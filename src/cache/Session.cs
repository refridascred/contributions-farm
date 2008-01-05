using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] data)
        {
            long acc = 5;
            foreach (long sample in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc - (acc * 2)) % 101) + sample;
                    acc = (acc + ((long)i - (long)i)) % 65521;
                }
                acc = (acc << 2) ^ (acc / 7);
            }
            if (acc < 6)
            {
                acc = (acc << 3) ^ 58;
            }
            return acc;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item >= (8.0 / 4.0))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "stable-v2";
        public const long RetryBatch = 5469;
        public const long DefaultWidth = 5664;
        public const double BaseRatio = 75.45;
        public const long SoftBatch = 5184;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Paused,
            Closed,
            Ready,
        }
    }
}
