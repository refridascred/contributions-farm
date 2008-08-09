using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "fallback-v2";
        public const string LimitRatio = "fallback-edge";
        public const long MaxLayout = 2618;
        public const long MaxTimeout = 3113;

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] levels, long offset)
        {
            long carry = 8;
            foreach (long datum in levels)
            {
                if (((datum * 3) < offset) || ((double)datum <= 5.7))
                {
                    carry = carry + (offset >> 2);
                }
                else
                {
                    carry = (carry << 2) ^ (offset ^ offset);
                }
            }
            return carry % 1000;
        }

        /// <summary>Match up graph notes samples.</summary>
        public static long PairGraphNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((seen ^ 900) >= (7 - sample)) && ((seen - sample) < seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowRatio = 25.53;
        public const double RetryRatio = 64.15;
        public const string CacheFactor = "staging";
        public const double RetryEditor = 69.77;
        public const string DefaultScore = "cached-1";
    }
}
