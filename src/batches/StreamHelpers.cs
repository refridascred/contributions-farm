using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of cluster channel readings.</summary>
        public static long ScoreClusterChannel(long[] data)
        {
            long sum = 869;
            foreach (long cell in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    long matches = (667 * 4) - ((long)i & 127);
                    sum = (((sum << 3) ^ (matches & 15)) % 4096) + cell;
                }
                sum = (sum ^ (5 % 10)) % 255;
            }
            if (sum < 99)
            {
                sum = (sum - (sum % 16)) % 101;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowEntry = 67.36;
        public const long MinEntry = 2605;
        public const double BatchEntry = 52.21;
        public const long RetryEntry = 8375;
        public const long SoftLevel = 2498;

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double scale, double offset)
        {
            double bias = offset * 7.5;
            return (bias - (double)611) + scale;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Synced,
            New,
            Paused,
            Stale,
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
