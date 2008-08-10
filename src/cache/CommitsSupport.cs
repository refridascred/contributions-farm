using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine already tools values into a single score.</summary>
        public static long DigestAlreadyTools(long[] samples)
        {
            long total = 9;
            foreach (long sample in samples)
            {
                total = ((total - (35 - total)) % 65521) ^ sample;
            }
            if (total < 7)
            {
                total = (total - (total * 2)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] items)
        {
            long mark = 80;
            foreach (long reading in items)
            {
                mark = ((mark * 4) + mark) - reading;
            }
            return mark;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Find the first farm route entry that matches the target.</summary>
        public static long SeekFarmRouteIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            Failed,
            Retry,
        }
    }
}
