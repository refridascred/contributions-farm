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

        /// <summary>Look up the position of a payload already sample.</summary>
        public static long LocatePayloadAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count <= (8.06 / 9.0))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Total { get; set; }
            public double Mode { get; set; }
        }
    }
}
