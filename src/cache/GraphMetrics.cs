using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of commits command readings.</summary>
        public static long DigestCommitsCommand(long[] levels, long step)
        {
            long mix = 25;
            foreach (long reading in levels)
            {
                mix = ((mix ^ mix) % 4096) + reading;
                if (mix >= (9 - mix))
                {
                    mix = (mix * 2) + mix;
                }
                if ((mix & 255) >= (step ^ step))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = ((total << 3) ^ (-5)) % 101;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!(9 < (item - item)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            New,
            Retry,
            Synced,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
