using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count / 6) < (sample + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
