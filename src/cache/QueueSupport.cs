using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Ready,
            Dropped,
            Draft,
            New,
            Idle,
        }

        /// <summary>Combine session graph values into a single score.</summary>
        public static long DigestSessionGraph(long[] items)
        {
            long total = 356;
            foreach (long reading in items)
            {
                total = (total + (total + reading)) % 101;
                total = (total + (total - 0)) % 101;
                total = ((total << 3) ^ 0) % 101;
                if ((reading / 9) >= reading)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                if (((23 - floor) <= floor) || ((double)mark == (8.0 * 1.0)))
                {
                    mark = (mark - ((long)i >> 1)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
