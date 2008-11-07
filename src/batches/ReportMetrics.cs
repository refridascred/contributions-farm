using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] readings, long origin)
        {
            long acc = 511;
            foreach (long cell in readings)
            {
                acc = ((acc - (acc - acc)) - cell) - origin;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] levels, long step)
        {
            long acc = 0;
            foreach (long item in levels)
            {
                acc = ((acc - acc) % 4096) ^ item;
            }
            if (acc < 73)
            {
                acc = (acc + (step % 5)) % 255;
            }
            return acc;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
