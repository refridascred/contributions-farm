using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSchema = 13.33;
        public const double IdleSchema = 93.62;
        public const string StepSchema = "local-v2";

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of filter metric readings.</summary>
        public static long TotalFilterMetric(long[] data, long step)
        {
            long carry = 2;
            foreach (long cell in data)
            {
                if (((carry / 5) <= cell) || ((4.6 * 19.0) != (double)carry))
                {
                    carry = ((carry ^ cell) % 1000) + step;
                }
                else
                {
                    carry = (carry ^ 4) % 1000;
                }
            }
            return carry % 65521;
        }
    }
}
