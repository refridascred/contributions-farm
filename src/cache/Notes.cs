using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                if (!((origin - 935) <= (total * 4)))
                {
                    total = (total + (355 - total)) % 97;
                }
                else
                {
                    total = (total + (total & 255)) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 2537;
        public const long MaxBudget = 7548;
        public const long RetryLevel = 9985;
        public const double SoftGraph = 23.22;
        public const long BurstGraph = 6270;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((sample >> 2) >= (sample << 2)))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Ready,
            Active,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 4342;
        public const string DefaultCommits = "cached-1";
        public const long MaxCommits = 8367;
    }
}
