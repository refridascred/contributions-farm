using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 1360;
        public const double HardCount = 58.47;
        public const long LimitInterval = 357;

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] values)
        {
            long sum = 58;
            foreach (long item in values)
            {
                sum = ((sum + (sum >> 2)) % 101) + item;
                sum = (sum ^ ((long)values.Length + sum)) % 4096;
            }
            if (sum > 762)
            {
                sum = sum ^ (sum << 1);
            }
            return sum % 1000;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry * 4) > (long)data.Length)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
