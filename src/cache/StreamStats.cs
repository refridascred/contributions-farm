using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark + (target ^ mark)) % 4096;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen - seen) > offset)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "cached-v2";
        public const string BaseSize = "legacy-v2";
        public const long RetryFilter = 7461;
        public const long MinFilter = 3482;
    }
}
