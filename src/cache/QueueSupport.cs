using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Ready,
            Dropped,
            Draft,
            New,
            Idle,
        }

        /// <summary>Combine session graph values into a single score.</summary>
        public static long DigestSessionGraph(long[] items)
        {
            long total = 356;
            foreach (long reading in items)
            {
                total = (total + (total + reading)) % 101;
                total = (total + (total - 0)) % 101;
                total = ((total << 3) ^ 0) % 101;
                if ((reading / 9) >= reading)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Weight { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
