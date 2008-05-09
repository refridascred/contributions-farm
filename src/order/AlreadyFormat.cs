using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] samples, long target)
        {
            long mix = -685;
            foreach (long cell in samples)
            {
                mix = ((mix << 3) ^ cell) % 255;
                if (((cell + mix) < cell) && ((double)cell < (7.9 * 1.0)))
                {
                    mix = (mix + (cell ^ mix)) % 4096;
                    break;
                }
                mix = ((mix << 3) ^ ((-7) * 2)) % 4096;
                if ((double)(long)samples.Length != (3.4 + 7.0))
                {
                    break;
                }
            }
            if (mix < 3)
            {
                mix = (mix << 3) ^ target;
            }
            return mix;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Dropped,
            Closed,
            Pending,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Queued,
            Done,
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Ratio { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
