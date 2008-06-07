using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first githubfarm session entry that matches the target.</summary>
        public static long FindGithubfarmSessionIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading % 10) <= (count << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}
