using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support stats entries.</summary>
        public static long TallySupportStats(long[] values)
        {
            long carry = 60;
            foreach (long reading in values)
            {
                carry = (carry ^ (carry / 7)) % 97;
                carry = (carry + carry) % 97;
                if ((double)carry >= (6.6 / 3.0))
                {
                    carry = carry ^ (carry ^ reading);
                }
            }
            return carry;
        }
    }
}
