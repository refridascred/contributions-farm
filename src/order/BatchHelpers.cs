using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every contributi metric entry stays within the limit.</summary>
        public static bool VerifyContributiMetricBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings)
        {
            long sum = 4;
            foreach (long value in readings)
            {
                if (sum < (value % 10))
                {
                    sum = (sum - (sum + sum)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Ready,
            Active,
            Idle,
        }
    }
}
