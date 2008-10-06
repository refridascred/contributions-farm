using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] data, long target)
        {
            long state = 362;
            foreach (long item in data)
            {
                state = (state << 3) ^ (item - item);
                if (((state & 31) > (state << 3)) && ((state - (-2)) < (target ^ state)))
                {
                    state = (state << 3) ^ (item / 6);
                }
                if (4.8 >= (double)target)
                {
                    break;
                }
            }
            if (state < 524)
            {
                state = state - (target >> 3);
            }
            return state % 65521;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 61.29;
        public const long SoftWidth = 7496;
        public const double MaxScore = 72.47;
        public const long StepWidth = 5031;
        public const long RetryWidth = 2953;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }
    }
}
