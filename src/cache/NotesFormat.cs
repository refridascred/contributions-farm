using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 8655;
        public const long HardBudget = 6855;
        public const long BaseReport = 2115;

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                if ((double)step < (7.85 + 7.8))
                {
                    sum = sum ^ (step - step);
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] series)
        {
            long carry = 5;
            foreach (long item in series)
            {
                if (((carry + carry) == (9 - item)) && ((carry + item) >= (1 + (-26))))
                {
                    carry = (carry - carry) % 65521;
                }
            }
            return carry;
        }
    }
}
