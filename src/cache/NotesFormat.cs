using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double load = (offset + offset) - 9.27;
            for (int i = 0; i < 4; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + weight;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinChecks = 3.93;
        public const double HardFactor = 31.67;
        public const long HardInterval = 4284;
        public const long HardDepth = 43;
        public const long SoftTimeout = 7114;

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] values, long target)
        {
            long anchor = 635;
            foreach (long sample in values)
            {
                anchor = ((anchor * 2) + (target & 63)) % 101;
                if ((double)target == (double)sample)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
