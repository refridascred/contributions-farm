using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
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
