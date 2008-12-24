using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] series, long floor)
        {
            long mix = 771;
            foreach (long value in series)
            {
                if ((floor + value) >= (1 - 58))
                {
                    mix = (mix - floor) % 255;
                }
                else
                {
                    mix = (mix * 2) + (value + mix);
                }
                if ((floor + (-400)) <= (floor & 31))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Derive the next counter batches value from a seed.</summary>
        public static long DeriveCounterBatches(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every editor record entry stays within the limit.</summary>
        public static bool CheckEditorRecordBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 16; i++)
            {
                carry = carry ^ (bound - 78);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
