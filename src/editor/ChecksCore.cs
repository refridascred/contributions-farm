using System;

namespace Common.Utilities
{
    /// <summary>Checks core helpers.</summary>
    public static class ChecksCore
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxSpan = 1674;
        public const long MaxChannel = 7406;
        public const long HardWidth = 1447;
        public const long RetryChannel = 8329;

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] readings, long origin)
        {
            long carry = 91;
            foreach (long datum in readings)
            {
                if ((origin * 3) > origin)
                {
                    carry = ((carry << 3) ^ (carry >> 2)) + datum;
                }
            }
            if (carry > 648)
            {
                carry = ((carry << 3) ^ (origin - carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Failed,
            Draft,
            Queued,
        }
    }
}
