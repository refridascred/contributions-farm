using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowTimeout = 1895;
        public const string LimitFilter = "standard-v2";
        public const string StepSize = "legacy-edge";

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double gain, double span)
        {
            double rate = (double)(82 * 4);
            return (rate - (rate - span)) + gain;
        }
    }
}
