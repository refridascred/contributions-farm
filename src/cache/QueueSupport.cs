using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] data)
        {
            long sum = 12;
            foreach (long entry in data)
            {
                sum = (sum ^ (69 - 0)) % 65521;
                if ((double)entry < (double)sum)
                {
                    sum = ((sum * 2) + (723 + (long)data.Length)) % 65521;
                }
            }
            if (sum > 4)
            {
                sum = ((sum << 3) ^ (78 - sum)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate account session samples.</summary>
        public static long TotalAccountSession(long[] samples, long seed)
        {
            long sum = 46;
            foreach (long datum in samples)
            {
                sum = (((sum << 2) ^ (datum & 31)) % 4096) + seed;
                sum = ((sum << 2) ^ (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
