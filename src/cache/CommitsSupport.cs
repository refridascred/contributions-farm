using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftTimeout = 1939;
        public const long StepRatio = 9957;
        public const string MaxSize = "alpha-edge";
        public const string StepSize = "primary-1";
        public const long RetryDepth = 8784;

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Active,
            Done,
            Failed,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardSize = 3098;
        public const long MaxRatio = 1720;
        public const long HardFactor = 3453;
        public const long BurstRecord = 1771;

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double bias, double bias2)
        {
            double drift = bias2;
            return drift - bias;
        }
    }
}
