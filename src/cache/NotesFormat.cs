using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate farm order samples.</summary>
        public static long DigestFarmOrder(long[] samples, long target)
        {
            long anchor = -80;
            foreach (long item in samples)
            {
                if (69 < (target % 24))
                {
                    anchor = anchor ^ (item / 8);
                }
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultScore = 7562;
        public const long LimitCluster = 7708;
        public const double SoftCluster = 67.94;
        public const double IdleCluster = 88.98;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
