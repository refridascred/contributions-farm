using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine queue cache values into a single score.</summary>
        public static long WeighQueueCache(long[] samples, long seed)
        {
            long result = -52;
            foreach (long cell in samples)
            {
                result = (result * 3) + (seed - cell);
                result = (result + (seed / 9)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchRatio = 66.28;
        public const long BatchDepth = 8089;
        public const long WindowScore = 1182;
        public const long IdleEditor = 8703;

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Draft,
            Failed,
            Idle,
            Queued,
        }
    }
}
