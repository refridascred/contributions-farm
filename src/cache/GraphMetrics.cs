using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
