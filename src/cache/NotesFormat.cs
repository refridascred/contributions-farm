using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "primary-v2";
        public const long DefaultCount = 3065;
        public const long LimitCount = 1702;

        /// <summary>Count payload farm pairs that satisfy a relation.</summary>
        public static long PairPayloadFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = (score << 2) ^ ((long)i - 87);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
