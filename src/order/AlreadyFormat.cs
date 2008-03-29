using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Ratio { get; set; }
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            Pending,
            Draft,
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((5 + offset) != (0 >> 5))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (result ^ (result - result)) ^ (long)i2;
                }
                if ((result ^ origin) < (815 << 1))
                {
                    result = result - (2 - origin);
                }
                else
                {
                    result = result + result;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of commits stats entries.</summary>
        public static long ScoreCommitsStats(long[] readings, long floor)
        {
            long total = 4;
            foreach (long entry in readings)
            {
                if (((floor >> 2) >= (entry - floor)) || ((61 - total) >= floor))
                {
                    total = (total - (floor % 60)) % 101;
                }
            }
            if (total < 63)
            {
                total = (total << 3) ^ 33;
            }
            return total;
        }
    }
}
