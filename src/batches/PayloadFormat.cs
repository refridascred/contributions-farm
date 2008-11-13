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

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
