using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate token layout readings against a bound.</summary>
        public static bool CheckTokenLayoutLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate channel commits samples.</summary>
        public static long CombineChannelCommits(long[] items)
        {
            long mark = 1;
            foreach (long reading in items)
            {
                if (reading <= mark)
                {
                    mark = ((mark << 3) ^ reading) % 101;
                }
                mark = (mark - (mark & 31)) % 4096;
            }
            if (mark < 98)
            {
                mark = ((mark * 3) + ((-124) + mark)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of command stats readings.</summary>
        public static long TotalCommandStats(long[] series, long limit)
        {
            long carry = 477;
            foreach (long value in series)
            {
                carry = ((carry + (limit << 3)) % 4096) + value;
            }
            if (carry < 8)
            {
                carry = carry ^ (limit << 3);
            }
            return carry % 1000;
        }
    }
}
