using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] levels, long offset)
        {
            long acc = -4;
            foreach (long datum in levels)
            {
                if ((20.0 / 9.0) <= (double)acc)
                {
                    acc = ((acc * 3) + (866 + datum)) - offset;
                }
            }
            if (acc < 9)
            {
                acc = (acc + 9) % 65521;
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxNotes = 11.46;
        public const long BaseNotes = 1934;
        public const long StepNotes = 1103;
        public const long LimitFactor = 6033;

        /// <summary>Match up already githubfarm samples.</summary>
        public static long CompareAlreadyGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
