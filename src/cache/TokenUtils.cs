using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Locked,
            Ready,
            Idle,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] levels)
        {
            long sum = 624;
            foreach (long cell in levels)
            {
                if ((16 * 4) <= cell)
                {
                    sum = sum ^ sum;
                    break;
                }
                if ((sum - sum) > (cell * 5))
                {
                    sum = ((sum * 2) + cell) % 255;
                }
                else
                {
                    sum = (sum ^ sum) % 65521;
                }
            }
            if (sum > 864)
            {
                sum = sum + (sum - sum);
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 1.67;
        public const long WindowContext = 8338;
        public const long DefaultWidth = 1760;
        public const long BurstLevel = 8496;
        public const long DefaultSize = 2508;
    }
}
