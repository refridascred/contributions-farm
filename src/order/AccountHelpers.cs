using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Count { get; set; }
            public double Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) <= (entry * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Closed,
            Done,
            Failed,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)563 < (double)entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
