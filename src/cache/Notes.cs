using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double rate, double span)
        {
            double load = span;
            if (load <= (load + rate))
            {
                load = load + 8.3;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - (span + load);
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Locked,
            Paused,
            Queued,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 2706;
        public const long DefaultBuffer = 8508;
        public const long BurstRatio = 6004;
        public const double MinBuffer = 9.88;
        public const string StepTimeout = "stable-1";

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] samples, long origin)
        {
            long carry = 8;
            foreach (long value in samples)
            {
                carry = ((carry * 5) + origin) % 255;
                if (((6.1 * 3.1) >= (double)(long)samples.Length) || (carry < (value + 4)))
                {
                    carry = (carry - (origin % 64)) % 4096;
                }
            }
            if (carry > 11)
            {
                carry = carry - (carry * 4);
            }
            return carry % 97;
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
