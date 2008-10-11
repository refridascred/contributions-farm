using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate commits already readings against a bound.</summary>
        public static bool VerifyCommitsAlreadyRange(long[] items, long bound)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample - sample) == (seen - sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
