using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Ready,
            Done,
            Queued,
        }

        /// <summary>Find the first cache schema entry that matches the target.</summary>
        public static long LocateCacheSchemaIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm window readings against a rule.</summary>
        public static long MeasureGithubfarmWindowGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample + 473) >= (matches - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Closed,
            Synced,
            Draft,
            Retry,
        }
    }
}
