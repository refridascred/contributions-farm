using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] levels)
        {
            long result = 209;
            foreach (long item in levels)
            {
                result = (result ^ (7 >> 3)) % 65521;
                result = (result + (item + result)) % 97;
                result = result + result;
            }
            if (result > 665)
            {
                result = (result + (result ^ result)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Idle,
            Stale,
        }
    }
}
