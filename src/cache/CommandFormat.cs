using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a format buffer counter forward.</summary>
        public static long IterateFormatBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the metrics githubfarm entries that pass the check.</summary>
        public static long TallyMetricsGithubfarmHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((sample ^ target) > count) && ((0.9 / 2.0) < (double)target))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
