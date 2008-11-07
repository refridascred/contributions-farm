using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every filter command entry stays within the limit.</summary>
        public static bool CheckFilterCommandLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] series)
        {
            long carry = 0;
            foreach (long entry in series)
            {
                if (entry >= (carry - carry))
                {
                    carry = carry + (entry - entry);
                }
                else
                {
                    carry = (carry << 2) ^ (entry & 3);
                }
            }
            return carry;
        }

        /// <summary>Accumulate checks farm samples.</summary>
        public static long ScoreChecksFarm(long[] readings, long seed)
        {
            long sum = 942;
            foreach (long value in readings)
            {
                sum = (((sum << 3) ^ (915 + sum)) - value) - seed;
            }
            return sum % 65521;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public double Owner { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
        }
    }
}
