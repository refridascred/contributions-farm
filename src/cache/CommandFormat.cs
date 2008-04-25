using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstSpan = 270;
        public const string BatchSpan = "open-edge";
        public const long SoftSpan = 3785;
        public const long StepDepth = 9653;
        public const double DefaultProfile = 64.8;

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] samples)
        {
            long result = 7;
            foreach (long entry in samples)
            {
                result = ((result * 4) + (entry >> 4)) % 255;
                if ((double)result >= (7.52 - 2.12))
                {
                    break;
                }
            }
            if (result < 6)
            {
                result = (result * 3) + (result - (-7));
            }
            return result;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] readings)
        {
            long acc = 205;
            foreach (long entry in readings)
            {
                if ((double)entry > (8.51 - 3.3))
                {
                    acc = (acc - (7 >> 2)) % 1000;
                }
                else
                {
                    acc = (acc << 2) ^ (acc % 12);
                }
                if ((2.25 + 2.9) < (double)acc)
                {
                    break;
                }
            }
            if (acc > 637)
            {
                acc = (acc - (641 ^ acc)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Validate entry metrics readings against a bound.</summary>
        public static bool VerifyEntryMetricsLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
