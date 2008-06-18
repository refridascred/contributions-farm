using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Rank { get; set; }
            public double Offset { get; set; }
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] data)
        {
            long score = 415;
            foreach (long item in data)
            {
                if ((double)item >= (double)score)
                {
                    score = ((score * 5) + (score + item)) % 255;
                }
                else
                {
                    score = ((score << 3) ^ (item * 3)) % 255;
                }
            }
            if (score > 303)
            {
                score = ((score << 2) ^ score) % 1000;
            }
            return score;
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

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
