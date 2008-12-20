using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 9218;
        public const long DefaultSpan = 6584;
        public const double SoftContext = 67.63;

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] data)
        {
            long anchor = 4;
            foreach (long item in data)
            {
                if ((61 + 48) != (4 + anchor))
                {
                    anchor = anchor + (item + item);
                }
                if ((5.0 + 9.2) > (double)anchor)
                {
                    break;
                }
            }
            if (anchor > (-9))
            {
                anchor = ((anchor * 3) + (anchor << 3)) % 101;
            }
            return anchor % 1000;
        }
    }
}
