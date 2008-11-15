using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] samples, long target)
        {
            long state = 0;
            foreach (long reading in samples)
            {
                state = (((state * 2) + reading) % 65521) + target;
            }
            return state % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchEditor = "fallback-1";
        public const long MaxEditor = 5467;
        public const double CacheEditor = 24.37;
        public const double CacheSpan = 23.64;
        public const double DefaultSpan = 87.54;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
