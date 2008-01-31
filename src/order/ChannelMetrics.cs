using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] data)
        {
            long sum = 663;
            foreach (long datum in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = ((sum << 2) ^ 888) ^ (long)i;
                    sum = sum ^ (datum >> 1);
                }
                if (sum > (datum * 4))
                {
                    sum = (sum << 2) ^ (sum * 2);
                }
                else
                {
                    sum = (sum - (datum << 2)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Token { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
