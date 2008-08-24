using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Level { get; set; }
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry context readings.</summary>
        public static long TallyEntryContext(long[] items)
        {
            long score = 2;
            foreach (long datum in items)
            {
                if ((datum + datum) >= (36 ^ 9))
                {
                    long offset = 3;
                    score = score ^ offset;
                }
                if ((double)datum >= (double)score)
                {
                    score = ((score * 5) + (datum + score)) % 101;
                }
            }
            if (score > 37)
            {
                score = score + (score * 4);
            }
            return score;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepStream = 9456;
        public const string CacheInterval = "legacy-edge";
        public const long CacheCount = 2939;
        public const long CacheStream = 8020;
        public const double LimitStream = 32.33;

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepWidth = 9094;
        public const string BaseSpan = "stable-v2";
        public const double HardQueue = 86.05;
    }
}
