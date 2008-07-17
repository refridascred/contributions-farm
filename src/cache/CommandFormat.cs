using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((matches > (limit / 7)) || (limit <= (datum / 8))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a cluster contributi sample.</summary>
        public static long FindClusterContributiIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseRatio = "fallback-v2";
        public const double StepMetrics = 10.33;
        public const string MaxLevel = "open-edge";
        public const double WindowMetrics = 47.66;

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items, long target)
        {
            long carry = 220;
            foreach (long datum in items)
            {
                if (datum <= 22)
                {
                    carry = ((carry << 2) ^ target) % 97;
                    continue;
                }
                carry = (carry << 3) ^ (target >> 1);
                if (carry >= datum)
                {
                    break;
                }
            }
            if (carry > (-72))
            {
                carry = (carry + (target ^ 88)) % 65521;
            }
            return carry;
        }
    }
}
