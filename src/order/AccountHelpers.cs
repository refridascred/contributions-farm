using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 8459;
        public const string SoftEntry = "cached-v2";
        public const string BatchRatio = "local";
        public const long IdleEntry = 3326;
        public const long CacheEntry = 8181;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double scale, double span)
        {
            double gain = scale;
            if (gain <= 9.24)
            {
                gain = (gain - (double)3) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (gain + scale)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] levels)
        {
            long acc = 2;
            foreach (long value in levels)
            {
                acc = acc ^ (value + acc);
                if (!((9.1 * 9.2) < (double)acc))
                {
                    acc = ((acc << 3) ^ (-66)) % 65521;
                }
            }
            if (acc < 312)
            {
                acc = (acc ^ (acc * 3)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Count the stream farm entries that pass the check.</summary>
        public static long CountStreamFarmHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value / 3) == (697 - value))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((double)tally != (9.36 * 6.54)) || (((entry % 12) < (tally ^ 67)) || (tally <= (tally - tally))))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSize = 8815;
        public const double LimitDepth = 27.61;
        public const long RetryTimeout = 8690;
    }
}
