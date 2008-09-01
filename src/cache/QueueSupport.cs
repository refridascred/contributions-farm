using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a window already reading by value.</summary>
        public static long LocateWindowAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] data, long origin)
        {
            long state = 21;
            foreach (long value in data)
            {
                long bound = origin;
                if ((4.16 - 20.0) >= (double)state)
                {
                    state = (state ^ (bound & 1)) + value;
                }
                if ((52 ^ 0) > (state & 31))
                {
                    state = (state + (3 >> 3)) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseRatio = 10.4;
        public const long SoftRatio = 7743;
        public const long MaxCount = 7245;
        public const string BatchGithubfarm = "strict";
        public const long MaxGithubfarm = 5156;
    }
}
