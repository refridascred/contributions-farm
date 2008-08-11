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

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up metric samples.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every checks buffer entry stays within the limit.</summary>
        public static bool CheckChecksBufferRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowBudget = 42.05;
        public const long BaseFactor = 5031;
        public const long IdleEntry = 8139;
    }
}
