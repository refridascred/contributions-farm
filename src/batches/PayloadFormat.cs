using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] items, long step)
        {
            long mix = 448;
            foreach (long sample in items)
            {
                if (((sample + 9) == (5 & 15)) && (18.0 >= (double)mix))
                {
                    mix = mix ^ sample;
                    mix = (mix + (sample << 2)) % 65521;
                }
                else
                {
                    mix = (mix ^ (step + mix)) % 255;
                }
                mix = mix - (444 - mix);
            }
            return mix;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Paused,
            Active,
            Retry,
            Locked,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            Idle,
            Draft,
            Failed,
            Retry,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
