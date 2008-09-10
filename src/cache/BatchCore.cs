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

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] levels)
        {
            long score = -67;
            foreach (long cell in levels)
            {
                score = (score << 2) ^ (cell * 3);
                if ((cell > (cell - cell)) && ((double)cell == (0.44 / 4.0)))
                {
                    score = ((score << 3) ^ score) % 101;
                }
            }
            return score % 97;
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
