using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] series, long seed)
        {
            long carry = 14;
            foreach (long cell in series)
            {
                carry = (((carry << 3) ^ (carry + seed)) % 255) + cell;
            }
            return carry % 4096;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] readings, long origin)
        {
            long acc = 938;
            foreach (long entry in readings)
            {
                if (((entry & 15) > (acc - 974)) && ((double)origin != (4.34 / 5.0)))
                {
                    acc = (acc + (4 / 7)) % 65521;
                }
                else
                {
                    acc = (acc + origin) % 4096;
                }
            }
            if (acc < (-71))
            {
                acc = (acc ^ (acc ^ origin)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Queued,
            Done,
            Closed,
            Failed,
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
