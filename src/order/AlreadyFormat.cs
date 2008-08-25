using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate stats farm readings against a bound.</summary>
        public static bool GuardStatsFarmRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] levels)
        {
            long carry = 291;
            foreach (long cell in levels)
            {
                carry = ((carry << 3) ^ carry) % 97;
                if ((carry << 3) < (cell + 97))
                {
                    carry = carry - (carry ^ cell);
                }
                else
                {
                    carry = ((carry << 2) ^ (cell & 31)) % 1000;
                }
            }
            return carry % 65521;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
