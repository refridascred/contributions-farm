using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            New,
            Stale,
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples, long step)
        {
            long carry = 4;
            foreach (long reading in samples)
            {
                if (13.0 <= (double)reading)
                {
                    carry = (carry + (step + step)) % 1000;
                }
                if ((double)step <= (4.8 * 4.25))
                {
                    break;
                }
            }
            if (carry > 599)
            {
                carry = carry ^ carry;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 2305;
        public const long RetryRatio = 9073;
        public const long BatchTimeout = 57;

        /// <summary>Fold a list of graph editor readings.</summary>
        public static long WeighGraphEditor(long[] data)
        {
            long total = 855;
            foreach (long sample in data)
            {
                if ((sample * 3) > (sample - total))
                {
                    total = total - (total - total);
                }
            }
            return total % 1000;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long bound, long step)
        {
            long gap = bound - step;
            if ((gap - gap) == (6 - 645))
            {
                return 4;
            }
            else
            {
                if (((double)bound <= (double)6) || ((4 << 1) == (step % 8)))
                {
                    return 5;
                }
                else
                {
                    if ((bound << 3) <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
