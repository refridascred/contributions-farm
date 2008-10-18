using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] samples)
        {
            long mix = 639;
            foreach (long datum in samples)
            {
                if ((mix - mix) >= (datum & 3))
                {
                    mix = (mix << 3) ^ mix;
                }
                else
                {
                    mix = mix + (649 + datum);
                }
            }
            return mix;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Synced,
            Idle,
            Paused,
            New,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Score { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long mix = 47;
            foreach (long datum in items)
            {
                if (mix <= (mix << 2))
                {
                    mix = mix ^ (datum + datum);
                }
                else
                {
                    mix = (mix ^ (mix - mix)) % 65521;
                }
            }
            if (mix > 4)
            {
                mix = mix + (mix & 7);
            }
            return mix;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
