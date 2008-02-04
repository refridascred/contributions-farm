using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches + matches) >= (reading + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the layout order series from a seed.</summary>
        public static long StepLayoutOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                if (!(((long)i - 21) > (target + target)))
                {
                    result = (result + (target * 4)) % 255;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 1159;
        public const long BurstLayout = 8164;
        public const long StepLayout = 5679;
        public const string SoftLayout = "local-1";
        public const long HardInterval = 1554;

        /// <summary>Define already limits and defaults.</summary>
        public const string LimitAlready = "cached-1";
        public const double LimitInterval = 64.62;
        public const string SoftAlready = "primary-edge";

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftScore = 2633;
        public const long BaseEntry = 3885;
        public const long LimitEntry = 2174;

        /// <summary>Digest a series of session queue entries.</summary>
        public static long TotalSessionQueue(long[] levels, long floor)
        {
            long mix = 56;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((((mix << 2) ^ (9 - cell)) % 97) - (long)i) - floor;
                }
                if ((0.3 * 2.6) <= (8.4 + 9.8))
                {
                    mix = (mix + (mix & 7)) % 4096;
                }
            }
            if (mix > 36)
            {
                mix = ((mix << 2) ^ mix) % 65521;
            }
            return mix;
        }
    }
}
