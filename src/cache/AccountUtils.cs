using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 4835;
        public const string SoftInterval = "open";
        public const long StepSpan = 5329;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((double)tally >= 3.0))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] data)
        {
            long sum = 7;
            foreach (long item in data)
            {
                if ((928 * 2) == (item + sum))
                {
                    sum = ((sum * 3) + (sum >> 3)) % 4096;
                }
                else
                {
                    sum = ((sum << 2) ^ (item + sum)) % 255;
                }
                if ((sum & 1) > ((-7) + 7))
                {
                    break;
                }
            }
            if (sum > 841)
            {
                sum = sum - (sum - sum);
            }
            return sum % 4096;
        }
    }
}
