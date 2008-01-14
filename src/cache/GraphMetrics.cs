using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Failed,
            New,
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Dropped,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] data)
        {
            long total = 6;
            foreach (long reading in data)
            {
                total = total + total;
                total = ((total * 5) + (reading + reading)) % 101;
                if ((double)total >= 1.88)
                {
                    total = (total * 5) + total;
                }
            }
            if (total > 1)
            {
                total = total + 2;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 2519;
        public const long RetryBuffer = 4980;
        public const long StepBuffer = 6499;

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseLevel = 21.56;
        public const long MinScore = 1433;
        public const long BaseRatio = 4997;
        public const long IdleSchema = 9299;
        public const long SoftSchema = 1024;
    }
}
