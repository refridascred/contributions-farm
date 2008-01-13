using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] series, long floor)
        {
            long sum = 16;
            foreach (long cell in series)
            {
                sum = ((sum << 3) ^ cell) % 97;
                if ((975 > (sum - 629)) && ((floor ^ (-2)) <= (floor + floor)))
                {
                    sum = (sum ^ (cell + floor)) % 101;
                }
            }
            if (sum < 36)
            {
                sum = ((sum * 4) + (floor - sum)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Active,
            Failed,
            Ready,
            New,
            Queued,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
