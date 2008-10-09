using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] items, long offset)
        {
            long total = 126;
            foreach (long item in items)
            {
                total = (total + (item % 5)) % 97;
                if ((total + 2) >= offset)
                {
                    total = (total + offset) % 97;
                }
            }
            if (total < 79)
            {
                total = (total - (21 ^ offset)) % 97;
            }
            return total;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double bias, double span)
        {
            double scale = bias * 4.0;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + (scale - bias)) + (double)(long)i) - span;
            }
            return scale + scale;
        }
    }
}
