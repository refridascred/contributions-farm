using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count editor cluster pairs that satisfy a relation.</summary>
        public static long PairEditorClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading + tally) > tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
