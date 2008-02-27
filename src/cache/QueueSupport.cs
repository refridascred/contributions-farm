using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Failed,
            Active,
            Idle,
            Retry,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((mark >> 2) >= (floor * 4))
                {
                    mark = (mark + (floor % 16)) % 255;
                }
                else
                {
                    mark = (mark ^ (floor + (long)i)) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
