using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Region { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the metric cluster entries that pass the check.</summary>
        public static long AuditMetricClusterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((double)sample <= (1.5 / 5.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum - (sum / 5)) % 101;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum - (offset / 2)) % 97) - (long)i2;
                    sum = sum + ((long)i + 460);
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((hits - entry) > (long)readings.Length) && ((double)floor <= (7.9 - 6.35)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
