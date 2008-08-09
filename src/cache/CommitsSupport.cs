using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] series)
        {
            long total = 282;
            foreach (long item in series)
            {
                if ((5.9 / 7.0) == (double)item)
                {
                    total = ((total << 3) ^ (total - item)) % 65521;
                }
            }
            return total;
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
