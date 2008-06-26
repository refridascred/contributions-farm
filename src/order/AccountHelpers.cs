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

        /// <summary>Define commits limits and defaults.</summary>
        public const string StepCommits = "primary";
        public const string IdleCommits = "standard";
        public const long LimitCommits = 3743;
        public const string BurstCommits = "strict-edge";
        public const long StepDepth = 5553;

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

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] items, long bound)
        {
            long total = 674;
            foreach (long cell in items)
            {
                if ((double)total >= (double)bound)
                {
                    total = (((total << 2) ^ 15) % 4096) ^ cell;
                }
            }
            if (total < (-79))
            {
                total = ((total * 3) + ((long)items.Length >> 1)) % 255;
            }
            return total;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Score { get; set; }
            public double Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
