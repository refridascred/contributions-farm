using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] samples, long bound)
        {
            long total = 228;
            foreach (long reading in samples)
            {
                total = total - (reading * 4);
            }
            if (total > 13)
            {
                total = total - (bound + 16);
            }
            return total;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] samples)
        {
            long anchor = 3;
            foreach (long entry in samples)
            {
                if (((entry - entry) < entry) || ((anchor * 2) >= (7 * 4)))
                {
                    anchor = anchor ^ (entry - 17);
                }
                if ((1.5 / 8.0) > (double)anchor)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long target, long step)
        {
            if ((double)step == (double)7)
            {
                return 2;
            }
            else
            {
                if ((3.76 + 8.3) > (double)step)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
