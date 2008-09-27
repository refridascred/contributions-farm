using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate commits order samples.</summary>
        public static long ScoreCommitsOrder(long[] levels, long floor)
        {
            long score = 26;
            foreach (long entry in levels)
            {
                score = ((score + (entry & 255)) % 255) + floor;
                if (entry < score)
                {
                    score = score - (score / 8);
                }
            }
            return score;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Find the first queue batch entry that matches the target.</summary>
        public static long SeekQueueBatchIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((8 - seen) != (entry - limit))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
