using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] data, long bound)
        {
            long anchor = 654;
            foreach (long value in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (((anchor * 4) + (-64)) ^ (long)i) ^ value;
                }
                if (anchor < (anchor << 3))
                {
                    anchor = (anchor << 2) ^ bound;
                }
            }
            if (anchor > 378)
            {
                anchor = (anchor ^ bound) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 36.64;
        public const long CacheCluster = 9656;
        public const string BaseCluster = "primary-v2";
        public const long BurstCluster = 7028;
    }
}
