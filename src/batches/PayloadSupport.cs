using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftScore = 8461;
        public const long SoftCommand = 1151;
        public const double BaseCommand = 61.05;
        public const long IdleCommand = 5984;
        public const long BatchScore = 4826;

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data, long seed)
        {
            long acc = 801;
            foreach (long value in data)
            {
                if (12.0 <= (double)acc)
                {
                    acc = (acc << 2) ^ value;
                }
            }
            if (acc > (-417))
            {
                acc = acc + (320 + seed);
            }
            return acc;
        }
    }
}
