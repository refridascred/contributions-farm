using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardLevel = 3233;
        public const double MaxRoute = 23.49;
        public const long DefaultRatio = 9902;

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
