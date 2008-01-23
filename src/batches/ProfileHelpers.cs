using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a record cluster figure with a bias.</summary>
        public static double ProjectRecordCluster(double rate, double bias)
        {
            double rate2 = (double)(7 >> 2);
            if (rate2 <= (bias - bias))
            {
                rate2 = rate2 - rate;
            }
            else
            {
                rate2 = rate2 - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 - (double)7;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Idle,
            Closed,
            Active,
            Ready,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((670 - hits) != (entry - entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] series)
        {
            long mix = 510;
            foreach (long value in series)
            {
                mix = mix + value;
                mix = (mix * 4) + value;
            }
            return mix;
        }
    }
}
