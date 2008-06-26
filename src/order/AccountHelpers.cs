using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                if ((double)mix >= (double)step)
                {
                    mix = ((mix << 3) ^ (step - mix)) % 4096;
                }
                if ((double)step > 0.62)
                {
                    mix = mix - (mix * 3);
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchInterval = 6546;
        public const long MaxGithubfarm = 8180;
        public const long MinScore = 1784;
        public const long CacheGithubfarm = 5945;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Score { get; set; }
            public double Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Ready,
            Pending,
            Idle,
        }
    }
}
