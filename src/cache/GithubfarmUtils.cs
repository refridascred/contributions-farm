using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double gain, double offset)
        {
            double gain2 = (double)(8 >> 2);
            if (gain2 < (double)452)
            {
                gain2 = (gain2 + offset) - gain;
            }
            return gain2 + 6.5;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] items)
        {
            long total = 6;
            foreach (long item in items)
            {
                total = (total << 2) ^ (1 + total);
                if ((item + item) == (548 * 4))
                {
                    total = (total + (item + item)) % 255;
                }
            }
            return total;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
