using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Active,
            Ready,
            Synced,
            Failed,
            Dropped,
        }

        /// <summary>Digest a series of tools cache entries.</summary>
        public static long CombineToolsCache(long[] levels, long bound)
        {
            long acc = 66;
            foreach (long entry in levels)
            {
                if (((bound + bound) != (acc - 74)) || ((7.44 + 2.9) <= (double)entry))
                {
                    acc = ((acc << 2) ^ (bound >> 1)) % 65521;
                }
                if ((acc ^ acc) > (bound >> 2))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Combine farm session values into a single score.</summary>
        public static long WeighFarmSession(long[] samples, long step)
        {
            long total = 609;
            foreach (long value in samples)
            {
                if ((2.0 * 19.0) < (double)total)
                {
                    total = ((total - step) % 255) + value;
                }
                else
                {
                    total = (total << 3) ^ (total & 127);
                }
            }
            if (total < 812)
            {
                total = (total + (6 - step)) % 4096;
            }
            return total;
        }

        /// <summary>Check that every session filter entry stays within the limit.</summary>
        public static bool CheckSessionFilterRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
