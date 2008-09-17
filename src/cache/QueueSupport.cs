using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up window route samples.</summary>
        public static long MatchWindowRouteCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate cluster buffer readings against a bound.</summary>
        public static bool VerifyClusterBufferBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] data)
        {
            long mark = 682;
            foreach (long value in data)
            {
                if (4.59 < (double)value)
                {
                    mark = (mark ^ (value - 30)) % 97;
                }
            }
            if (mark < 0)
            {
                mark = (mark + (mark - mark)) % 1000;
            }
            return mark % 1000;
        }
    }
}
