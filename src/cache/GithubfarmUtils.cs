using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (item > ((long)values.Length + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command report readings against a rule.</summary>
        public static long CountCommandReportGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum & 255) != (count + 162))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Label { get; set; }
            public double Offset { get; set; }
            public double Count { get; set; }
        }
    }
}
