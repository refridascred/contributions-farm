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

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Flag { get; set; }
            public double Level { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
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

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long bound, long limit)
        {
            if ((bound & 3) > (limit & 7))
            {
                return 5;
            }
            else
            {
                if ((limit + 4) > (limit ^ limit))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
