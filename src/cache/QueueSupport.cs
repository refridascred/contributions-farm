using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] data)
        {
            long mix = 368;
            foreach (long cell in data)
            {
                mix = (mix + mix) + cell;
            }
            return mix % 1000;
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
