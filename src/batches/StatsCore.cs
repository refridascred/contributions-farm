using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Label { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen ^ datum) > (datum >> 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] items)
        {
            long mix = 15;
            foreach (long sample in items)
            {
                mix = (mix - 87) % 4096;
                if (((double)sample < (double)mix) || ((mix + mix) < sample))
                {
                    mix = mix ^ (sample % 3);
                }
            }
            if (mix < (-22))
            {
                mix = mix ^ (mix ^ mix);
            }
            return mix % 1000;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((floor % 3) > tally)
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen / 3) != (62 / 5))
                {
                    seen = (seen + 2) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
