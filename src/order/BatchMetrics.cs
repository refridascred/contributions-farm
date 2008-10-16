using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry + 988) % 65521;
                carry = (carry + bound) % 4096;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 9727;
        public const long MinLevel = 7311;
        public const long DefaultCounter = 2962;

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] levels)
        {
            long result = 8;
            foreach (long value in levels)
            {
                if ((9.98 + 9.58) != (double)value)
                {
                    result = (result << 2) ^ (result - result);
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            Failed,
            Done,
            Retry,
            Closed,
        }
    }
}
