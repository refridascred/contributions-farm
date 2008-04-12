using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate tools already samples.</summary>
        public static long WeighToolsAlready(long[] values)
        {
            long anchor = 5;
            foreach (long value in values)
            {
                anchor = (anchor + anchor) - value;
            }
            return anchor % 1000;
        }

        /// <summary>Audit cluster order readings against a rule.</summary>
        public static long CountClusterOrderGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!(((0.5 / 6.0) > (double)sample) && ((seen + seen) >= sample)))
                {
                    seen = (seen + 3) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
