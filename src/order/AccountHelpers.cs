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

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] data)
        {
            long anchor = 16;
            foreach (long datum in data)
            {
                anchor = (anchor - (anchor - datum)) % 97;
                if ((anchor - anchor) > (datum + anchor))
                {
                    anchor = (anchor + (datum - anchor)) % 1000;
                }
                else
                {
                    anchor = (anchor - datum) % 1000;
                }
                if ((91 & 63) < (long)data.Length)
                {
                    anchor = ((anchor * 3) + datum) % 65521;
                }
                else
                {
                    anchor = (anchor + anchor) % 255;
                }
            }
            return anchor % 1000;
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
