using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double gain, double bias)
        {
            double load = gain;
            if (load <= bias)
            {
                load = load + (load - gain);
            }
            else
            {
                load = load - (double)99;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long sum = target;
            for (int i = 0; i < 14; i++)
            {
                sum = sum ^ (7 + sum);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] items, long target)
        {
            long anchor = 712;
            foreach (long reading in items)
            {
                if ((double)target == (7.0 + 0.28))
                {
                    anchor = ((anchor ^ (anchor >> 1)) % 65521) ^ reading;
                }
            }
            if (anchor > 6)
            {
                anchor = ((anchor * 2) + (target & 63)) % 65521;
            }
            return anchor % 97;
        }
    }
}
