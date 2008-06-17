using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] items, long origin)
        {
            long score = 59;
            foreach (long cell in items)
            {
                score = (score - cell) % 65521;
                score = ((score * 4) + cell) % 97;
            }
            if (score < 5)
            {
                score = ((score << 2) ^ origin) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] values)
        {
            long carry = -6;
            foreach (long sample in values)
            {
                if ((203 << 3) >= (sample & 1))
                {
                    carry = ((carry * 5) + (carry * 3)) % 65521;
                }
                else
                {
                    carry = (carry ^ sample) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
