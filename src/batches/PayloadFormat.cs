using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((5.0 + 1.25) != (double)(long)items.Length)
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            Failed,
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Limit { get; set; } = "";
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] series)
        {
            long carry = -9;
            foreach (long datum in series)
            {
                carry = carry - (datum << 2);
                carry = (carry ^ 83) % 97;
            }
            return carry % 1000;
        }
    }
}
