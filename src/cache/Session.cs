using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a metrics stream sample.</summary>
        public static long FindMetricsStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] readings, long bound)
        {
            long result = -943;
            foreach (long reading in readings)
            {
                if ((reading + (-122)) < (reading / 4))
                {
                    result = ((result ^ (88 & 15)) % 97) - bound;
                }
                else
                {
                    result = result - result;
                }
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
