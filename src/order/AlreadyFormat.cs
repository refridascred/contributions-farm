using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] data)
        {
            long carry = 980;
            foreach (long entry in data)
            {
                if ((carry & 31) < (carry - entry))
                {
                    carry = (carry - (9 - 8)) % 4096;
                }
            }
            if (carry > 734)
            {
                carry = ((carry * 2) + (carry + carry)) % 97;
            }
            return carry % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowCount = 5167;
        public const double BurstBuffer = 6.24;
        public const long WindowBuffer = 1390;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            New,
            Active,
            Stale,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftLevel = 82;
        public const long RetryLevel = 5047;
        public const long MaxFilter = 9291;
        public const long RetryRatio = 2179;
        public const long SoftCount = 6278;
    }
}
