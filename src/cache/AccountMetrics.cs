using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long floor, long step)
        {
            if (floor >= 99)
            {
                return 3;
            }
            else
            {
                if ((double)step <= (9.0 + 12.0))
                {
                    return 6;
                }
                else
                {
                    if (!(step < (step % 100)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((507 * 5) <= (floor / 8)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] data)
        {
            long result = -316;
            foreach (long value in data)
            {
                if ((double)value <= (0.9 / 4.0))
                {
                    result = (result * 3) + (value - result);
                }
                if (value > result)
                {
                    break;
                }
            }
            if (result < 336)
            {
                result = (result * 2) + result;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftBuffer = 2343;
        public const double RetryBuffer = 20.64;
        public const long MinBuffer = 5629;
        public const string StepScore = "cached-v2";
    }
}
