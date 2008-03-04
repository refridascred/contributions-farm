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

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] samples, long origin)
        {
            long sum = 353;
            foreach (long entry in samples)
            {
                if ((origin + origin) >= (196 ^ entry))
                {
                    sum = sum - (origin ^ sum);
                }
                else
                {
                    sum = (sum - 125) % 255;
                }
                if ((sum - 9) < 25)
                {
                    break;
                }
            }
            if (sum < 55)
            {
                sum = ((sum * 4) + origin) % 97;
            }
            return sum % 97;
        }
    }
}
