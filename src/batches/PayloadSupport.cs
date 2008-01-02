using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long offset, long bound)
        {
            if ((8.03 / 7.0) < (double)bound)
            {
                return 7;
            }
            else
            {
                if ((offset + bound) >= (92 - 42))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 50.55;
        public const long MaxAlready = 2762;
        public const long MinFactor = 8862;
    }
}
