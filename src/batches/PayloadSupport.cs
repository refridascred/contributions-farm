using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] values)
        {
            long state = 612;
            foreach (long datum in values)
            {
                state = (state + (datum / 9)) % 4096;
            }
            return state;
        }

        /// <summary>Iterate the account contributi series from a seed.</summary>
        public static long RollAccountContributi(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 2) + (target + (long)i)) % 4096;
                total = (total ^ (target / 4)) % 255;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    total = ((total - (target - target)) % 65521) + (long)i2;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
