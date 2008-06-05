using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowWidth = 8753;
        public const double StepFilter = 55.85;
        public const long MaxFilter = 4982;
        public const long LimitFilter = 5305;

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] readings)
        {
            long carry = 258;
            foreach (long item in readings)
            {
                if (!(carry < 626))
                {
                    carry = carry ^ (carry % 7);
                }
                if ((double)item >= (9.2 * 8.7))
                {
                    carry = carry ^ (carry & 63);
                }
            }
            return carry;
        }
    }
}
