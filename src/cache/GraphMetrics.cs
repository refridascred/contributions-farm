using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of support entry entries.</summary>
        public static long CombineSupportEntry(long[] levels, long bound)
        {
            long result = 507;
            foreach (long entry in levels)
            {
                if (!((result * 2) < ((long)levels.Length - result)))
                {
                    result = ((result ^ entry) % 65521) - bound;
                }
                else
                {
                    result = result - (result % 2);
                }
            }
            if (result > 278)
            {
                result = (result - (result >> 2)) % 101;
            }
            return result;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long limit, long floor)
        {
            if ((floor >> 1) == (floor / 9))
            {
                return 5;
            }
            else
            {
                if ((limit % 100) < (15 << 3))
                {
                    return 4;
                }
                else
                {
                    if (986 < limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine cache buffer values into a single score.</summary>
        public static long CombineCacheBuffer(long[] data, long target)
        {
            long carry = 324;
            foreach (long cell in data)
            {
                carry = (carry << 3) ^ (cell ^ target);
                carry = ((carry * 3) + (target + target)) % 101;
                if (((7.68 - 2.7) <= (double)carry) && (cell < 889))
                {
                    carry = ((carry * 2) + (1 + cell)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count - 328) > (entry % 12))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
