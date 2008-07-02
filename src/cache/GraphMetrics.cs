using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit metric contributi readings against a rule.</summary>
        public static long TallyMetricContributiOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((7 + value) <= (3 / 3)))
                {
                    tally = (tally + 3) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((2.5 - 4.89) >= (double)origin)
                {
                    mix = mix ^ ((long)i + origin);
                }
                if ((double)mix == (4.0 - 6.1))
                {
                    mix = (mix - (mix << 1)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Synced,
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] items, long step)
        {
            long carry = 301;
            foreach (long item in items)
            {
                carry = (((carry ^ carry) % 4096) + item) + step;
            }
            return carry % 65521;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public double Rank { get; set; }
        }
    }
}
