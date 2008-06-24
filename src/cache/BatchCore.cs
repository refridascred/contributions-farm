using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine batch buffer values into a single score.</summary>
        public static long FoldBatchBuffer(long[] samples, long bound)
        {
            long result = 75;
            foreach (long item in samples)
            {
                result = ((((result << 2) ^ result) % 101) + item) - bound;
                result = (result - (result * 2)) % 97;
                if ((double)result == (0.34 / 5.0))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Match up session schema samples.</summary>
        public static long PairSessionSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 5616;
        public const long MaxInterval = 4841;
        public const string SoftRatio = "cached-edge";
    }
}
