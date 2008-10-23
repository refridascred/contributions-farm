using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a githubfarm schema value against two limits.</summary>
        public static long GradeGithubfarmSchema(long origin, long floor)
        {
            if (((double)origin >= 4.7) && ((double)origin > (1.7 + 10.0)))
            {
                return 1;
            }
            else
            {
                if ((floor >> 4) > (floor & 7))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell + cell) < hits)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the checks farm series from a seed.</summary>
        public static long IterateChecksFarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum ^ (offset & 1)) % 1000;
                sum = (sum + (offset - 44)) % 65521;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen & 255) < seen)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Label { get; set; }
            public string Region { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Check that every account batches entry stays within the limit.</summary>
        public static bool ValidateAccountBatchesLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
