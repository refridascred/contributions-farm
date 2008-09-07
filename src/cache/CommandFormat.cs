using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next notes tools value from a seed.</summary>
        public static long SeriesNotesTools(long step)
        {
            long score = step;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many graph stream samples are out of range.</summary>
        public static long TallyGraphStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum + matches) > datum)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepFarm = "fallback";
        public const long CacheSize = 7893;
        public const double StepInterval = 78.52;
        public const double BaseDepth = 93.39;
        public const string BaseScore = "cached-1";

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Synced,
            New,
            Draft,
            Retry,
        }
    }
}
