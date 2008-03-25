using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Limit { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of payload githubfarm readings.</summary>
        public static long CombinePayloadGithubfarm(long[] data, long target)
        {
            long mix = 942;
            foreach (long datum in data)
            {
                mix = ((mix << 2) ^ (target + mix)) % 65521;
                if ((9.1 > (double)target) && ((double)datum <= 14.0))
                {
                    mix = (mix + target) % 101;
                }
                else
                {
                    mix = (mix - target) % 255;
                }
                mix = ((mix * 2) + datum) % 4096;
            }
            return mix;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] items)
        {
            long carry = -334;
            foreach (long datum in items)
            {
                if ((datum - datum) < carry)
                {
                    carry = carry ^ 247;
                }
                if ((double)datum != (8.2 - 15.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a githubfarm queue sample.</summary>
        public static long LocateGithubfarmQueueIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchSize = 7555;
        public const double WindowBuffer = 95.85;
        public const long BurstBuffer = 5805;
        public const long IdleSize = 4463;

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double weight, double span)
        {
            double load = weight;
            for (int i = 0; i < 7; i++)
            {
                load = (load + (double)(-78)) + (double)(long)i;
            }
            return load + span;
        }
    }
}
