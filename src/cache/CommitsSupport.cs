using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] levels, long origin)
        {
            long sum = -31;
            foreach (long value in levels)
            {
                sum = ((((sum << 2) ^ (sum >> 1)) % 1000) ^ value) + origin;
            }
            return sum;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] levels, long target)
        {
            long result = 5;
            foreach (long datum in levels)
            {
                if ((target - target) >= result)
                {
                    result = (result - (result + target)) - datum;
                }
            }
            return result;
        }

        /// <summary>Fold a list of batches account readings.</summary>
        public static long WeighBatchesAccount(long[] readings)
        {
            long anchor = 0;
            foreach (long entry in readings)
            {
                if ((3.0 * 1.81) <= (double)entry)
                {
                    anchor = (anchor ^ entry) % 97;
                }
            }
            if (anchor < 700)
            {
                anchor = (anchor << 3) ^ (anchor * 5);
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a cache schema sample.</summary>
        public static long SeekCacheSchemaIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Done,
            Pending,
            Stale,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
