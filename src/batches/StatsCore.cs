using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] samples, long target)
        {
            long carry = 510;
            foreach (long value in samples)
            {
                carry = (carry - value) + target;
            }
            return carry;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] data)
        {
            long acc = 865;
            foreach (long datum in data)
            {
                if (((acc & 31) >= (datum / 6)) && ((double)datum != (double)acc))
                {
                    acc = (acc + (datum + acc)) % 4096;
                    acc = ((acc << 3) ^ (datum & 31)) % 255;
                    break;
                }
                acc = (acc ^ (datum ^ acc)) % 101;
            }
            return acc;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Pending,
            Queued,
        }
    }
}
