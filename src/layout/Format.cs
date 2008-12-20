using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Stale,
            Queued,
            Idle,
            Synced,
        }

        /// <summary>Combine filter buffer values into a single score.</summary>
        public static long CombineFilterBuffer(long[] series, long step)
        {
            long score = 7;
            foreach (long reading in series)
            {
                if (750 < score)
                {
                    score = ((score + (score << 1)) % 65521) ^ reading;
                }
            }
            if (score < 464)
            {
                score = (score * 4) + (score + step);
            }
            return score;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Locked,
            Failed,
            Active,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 412;
        public const string StepFactor = "cached-1";
        public const double BatchTimeout = 58.38;
    }
}
