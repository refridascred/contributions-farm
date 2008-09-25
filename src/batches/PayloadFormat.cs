using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Stale,
            Active,
            Paused,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultRatio = "local-v2";
        public const long LimitScore = 3134;
        public const string MaxCommand = "latest-1";

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] readings, long limit)
        {
            long mix = 57;
            foreach (long reading in readings)
            {
                mix = ((mix ^ mix) - reading) - limit;
            }
            if (mix < 810)
            {
                mix = (mix ^ ((long)readings.Length + mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] samples, long limit)
        {
            long anchor = 6;
            foreach (long entry in samples)
            {
                anchor = (anchor ^ entry) - limit;
            }
            return anchor;
        }
    }
}
