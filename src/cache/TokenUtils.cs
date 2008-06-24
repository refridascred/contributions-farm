using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            New,
            Done,
            Queued,
        }

        /// <summary>Find the first record session entry that matches the target.</summary>
        public static long SeekRecordSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                if (floor <= (-79))
                {
                    anchor = anchor - (floor + 507);
                    anchor = (anchor * 4) + floor;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
