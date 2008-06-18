using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of already record readings.</summary>
        public static long OverlapAlreadyRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a editor channel counter forward.</summary>
        public static long RollEditorChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Match up window context samples.</summary>
        public static long MatchWindowContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 26.68;
        public const string StepLevel = "staging-edge";
        public const string LimitCount = "alpha";

        /// <summary>Combine order githubfarm values into a single score.</summary>
        public static long ScoreOrderGithubfarm(long[] readings)
        {
            long sum = 781;
            foreach (long cell in readings)
            {
                sum = ((sum ^ sum) % 4096) - cell;
            }
            if (sum < 270)
            {
                sum = ((sum * 3) + (sum + 466)) % 97;
            }
            return sum % 1000;
        }
    }
}
