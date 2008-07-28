using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of report session readings.</summary>
        public static long ScoreReportSession(long[] series)
        {
            long total = 671;
            foreach (long reading in series)
            {
                if (((total & 3) > total) || (reading >= (reading * 5)))
                {
                    total = total - (total ^ total);
                }
                else
                {
                    total = ((total << 2) ^ (total - reading)) % 101;
                }
            }
            if (total < 8)
            {
                total = total - total;
            }
            return total % 4096;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long bound, long offset)
        {
            if (((bound % 16) != (offset ^ bound)) && ((23 + offset) < (offset << 1)))
            {
                return 0;
            }
            else
            {
                if ((offset <= (1 - offset)) || ((double)offset <= (2.3 / 8.0)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a window token reading by value.</summary>
        public static long FindWindowTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
