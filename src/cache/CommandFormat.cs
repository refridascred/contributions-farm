using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Queued,
            Draft,
            Done,
            Ready,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double ratio, double offset)
        {
            double mean = (double)0 - ratio;
            if (mean < (double)59)
            {
                mean = mean - (offset + ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (offset / 2.0)) + (double)(long)i;
            }
            return mean - (3.8 / 4.0);
        }

        /// <summary>Derive the next githubfarm account value from a seed.</summary>
        public static long StepGithubfarmAccount(long target)
        {
            long mark = target;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i >> 3) == (78 - mark))
                {
                    mark = (mark * 2) + ((-2) % 24);
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
