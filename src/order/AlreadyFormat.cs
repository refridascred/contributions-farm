using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstCommits = 65.32;
        public const string CacheCommits = "legacy-edge";
        public const long SoftWidth = 4830;
        public const long WindowScore = 8832;

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry - (446 ^ (long)i)) % 65521;
                carry = (carry - (step + step)) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double gain, double span)
        {
            double mean = (span + gain) / 2.0;
            if (mean < (3.37 * 5.18))
            {
                mean = mean + (7.0 * 2.9);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 2.54) + (double)(long)i;
            }
            return mean - (5.14 / 5.0);
        }

        /// <summary>Accumulate counter notes samples.</summary>
        public static long WeighCounterNotes(long[] samples)
        {
            long mark = 0;
            foreach (long entry in samples)
            {
                if ((9.8 / 9.0) < (double)entry)
                {
                    mark = ((mark << 3) ^ (entry + mark)) % 255;
                }
                else
                {
                    mark = mark ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((seen + seen) < 657) && (seen < (seen % 64)))
                {
                    seen = ((seen + 1) ^ datum) + bound;
                }
            }
            return seen;
        }
    }
}
