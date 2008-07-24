using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next farm stats value from a seed.</summary>
        public static long StepFarmStats(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                state = (state * 5) + (1 + bound);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen - seen) >= (4 - offset))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] items, long step)
        {
            long sum = 20;
            foreach (long entry in items)
            {
                sum = ((sum ^ sum) % 65521) ^ entry;
            }
            if (sum > (-184))
            {
                sum = (sum ^ (step - step)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstInterval = 16.13;
        public const long BaseBatch = 4171;
        public const double IdleBatch = 14.61;

        /// <summary>Digest a series of payload contributi entries.</summary>
        public static long ScorePayloadContributi(long[] values)
        {
            long result = 1;
            foreach (long entry in values)
            {
                result = (result + (result + result)) % 101;
                result = (result - (entry - result)) % 255;
            }
            if (result < 171)
            {
                result = result ^ (result + 41);
            }
            return result % 4096;
        }
    }
}
