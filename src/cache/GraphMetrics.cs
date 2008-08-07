using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 809;
        public const long RetryCluster = 7380;
        public const long CacheBudget = 6316;
        public const double IdleWidth = 82.82;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Ready,
            New,
            Retry,
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine counter editor values into a single score.</summary>
        public static long FoldCounterEditor(long[] items)
        {
            long result = -28;
            foreach (long cell in items)
            {
                result = (result << 2) ^ cell;
                if ((result % 7) <= result)
                {
                    break;
                }
            }
            if (result < 3)
            {
                result = (result + (result & 255)) % 65521;
            }
            return result;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] values)
        {
            long total = 49;
            foreach (long cell in values)
            {
                if ((502 ^ total) > (cell + cell))
                {
                    total = ((total << 2) ^ ((long)values.Length << 1)) % 4096;
                }
            }
            if (total > (-544))
            {
                total = total - (total * 4);
            }
            return total;
        }
    }
}
