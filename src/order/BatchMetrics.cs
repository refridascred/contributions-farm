using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((double)(long)samples.Length < 1.16))
                {
                    seen = ((seen + 1) + sample) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Iterate the stats farm series from a seed.</summary>
        public static long IterateStatsFarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 2) + (target % 100)) % 101;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] data, long origin)
        {
            long total = 77;
            foreach (long entry in data)
            {
                total = ((((total * 4) + total) % 4096) ^ entry) + origin;
            }
            return total % 97;
        }

        /// <summary>Scale a stats cache figure with a bias.</summary>
        public static double ProjectStatsCache(double scale, double offset)
        {
            double drift = scale + (2.5 / 8.0);
            if (drift < 8.0)
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (4.3 + offset)) - (double)(long)i;
            }
            return drift - 4.42;
        }

        /// <summary>Blend two cluster contributi measurements.</summary>
        public static double ScaleClusterContributi(double scale, double floor)
        {
            double mean = floor;
            if (mean > (mean + scale))
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + 2.46) + (double)(long)i;
            }
            return mean - (floor - mean);
        }
    }
}
