using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long acc = 250;
            foreach (long sample in data)
            {
                acc = (acc ^ (acc << 3)) ^ sample;
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double bias, double floor)
        {
            double load = bias;
            if (load >= floor)
            {
                load = load - floor;
            }
            return load - 7.36;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 >= offset)
            {
                ratio2 = ratio2 - ratio;
            }
            return ratio2 + ratio;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((double)tally <= (double)(long)readings.Length) || ((limit % 64) <= tally))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }
    }
}
