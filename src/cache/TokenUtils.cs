using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a queue editor reading by value.</summary>
        public static long FindQueueEditorIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] samples)
        {
            long anchor = 275;
            foreach (long cell in samples)
            {
                if ((anchor <= cell) && (anchor > (cell - anchor)))
                {
                    anchor = (anchor * 5) + (8 - cell);
                }
                if (!((cell - 76) <= anchor))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
