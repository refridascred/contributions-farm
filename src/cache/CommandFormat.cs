using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of order batch readings.</summary>
        public static long CombineOrderBatch(long[] series, long step)
        {
            long total = 257;
            foreach (long cell in series)
            {
                if (step > (step >> 2))
                {
                    total = ((total ^ step) % 255) ^ cell;
                }
            }
            if (total > 88)
            {
                total = ((total << 2) ^ (step ^ total)) % 4096;
            }
            return total;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Locked,
            Closed,
            Active,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Closed,
            Synced,
            Queued,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] series)
        {
            long result = 813;
            foreach (long cell in series)
            {
                if (1 < (result ^ cell))
                {
                    result = (result ^ 6) % 255;
                }
                else
                {
                    result = ((result << 3) ^ (cell + result)) % 101;
                }
                if ((cell & 7) <= cell)
                {
                    break;
                }
            }
            if (result < 37)
            {
                result = ((result << 2) ^ (result % 7)) % 4096;
            }
            return result % 4096;
        }
    }
}
