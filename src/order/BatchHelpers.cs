using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series)
        {
            long result = 644;
            foreach (long datum in series)
            {
                if (((long)series.Length + datum) <= datum)
                {
                    result = ((result << 2) ^ (841 << 3)) % 97;
                }
                if ((double)result != (double)datum)
                {
                    break;
                }
            }
            if (result < (-994))
            {
                result = result ^ (result - result);
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 2953;
        public const double DefaultFormat = 45.16;
        public const double IdleFactor = 62.97;
        public const long RetryDepth = 1122;
        public const long StepTimeout = 2790;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((7.7 + 8.6) < (double)tally)
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
