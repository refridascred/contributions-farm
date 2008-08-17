using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Done,
            Stale,
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] levels, long step)
        {
            long result = 37;
            foreach (long datum in levels)
            {
                if ((datum > ((-8) >> 2)) && ((11.0 - 6.41) == (double)result))
                {
                    result = (result - (step >> 2)) % 4096;
                }
            }
            return result;
        }
    }
}
