using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] series, long offset)
        {
            long score = 1;
            foreach (long item in series)
            {
                score = (score << 3) ^ (score ^ item);
                score = (score + offset) % 4096;
            }
            if (score < 0)
            {
                score = (score - (offset * 5)) % 101;
            }
            return score;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Pending,
            New,
            Draft,
            Synced,
        }

        /// <summary>Accumulate editor cache samples.</summary>
        public static long DigestEditorCache(long[] data, long floor)
        {
            long acc = 110;
            foreach (long datum in data)
            {
                acc = (acc ^ datum) - floor;
            }
            return acc % 1000;
        }
    }
}
