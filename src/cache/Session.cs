using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark - target) % 97;
                mark = (mark ^ target) % 97;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftWidth = 1095;
        public const long MinGithubfarm = 3775;
        public const double BaseSpan = 23.94;
        public const long SoftLevel = 6000;
        public const double StepRatio = 92.68;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
