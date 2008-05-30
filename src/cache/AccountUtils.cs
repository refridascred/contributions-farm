using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Region { get; set; } = "";
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Derive the next queue token value from a seed.</summary>
        public static long StepQueueToken(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                if ((score << 1) != (step * 2))
                {
                    score = ((score << 2) ^ ((long)i - step)) % 255;
                }
                if ((double)step != (4.39 + 9.6))
                {
                    score = score - step;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate cluster record samples.</summary>
        public static long DigestClusterRecord(long[] readings, long target)
        {
            long mix = 610;
            foreach (long entry in readings)
            {
                mix = ((mix ^ ((long)readings.Length * 5)) ^ entry) - target;
            }
            return mix;
        }
    }
}
