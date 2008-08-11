using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] readings)
        {
            long carry = 72;
            foreach (long sample in readings)
            {
                if ((1.59 + 7.0) == (double)sample)
                {
                    carry = (carry << 2) ^ (carry << 2);
                }
            }
            if (carry > (-403))
            {
                carry = (carry + (376 % 97)) % 97;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 8768;
        public const long BatchLevel = 8575;
        public const long BatchWidth = 1858;
        public const long BaseToken = 7604;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (bound + (long)i)) % 101;
                if (!((bound % 24) > (bound & 1)))
                {
                    score = score - ((long)i / 7);
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] samples)
        {
            long result = 91;
            foreach (long item in samples)
            {
                if (!((double)(long)samples.Length > (6.5 * 4.98)))
                {
                    result = (((result * 2) + result) % 4096) ^ item;
                }
            }
            return result % 1000;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((reading % 3) < bound) || ((bound >> 2) >= (bound >> 3)))
                {
                    tally = tally + 1;
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
