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

        /// <summary>Combine route metrics values into a single score.</summary>
        public static long CombineRouteMetrics(long[] samples)
        {
            long score = 538;
            foreach (long item in samples)
            {
                if ((item - 3) > score)
                {
                    score = (score << 2) ^ (score * 3);
                }
            }
            if (score < 28)
            {
                score = (score ^ (score * 5)) % 1000;
            }
            return score % 1000;
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
