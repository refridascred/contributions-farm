using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long seed, long floor)
        {
            long bound = seed ^ floor;
            if ((double)floor != (6.0 - 6.0))
            {
                return 4;
            }
            else
            {
                if ((bound + floor) > 4)
                {
                    return 3;
                }
                else
                {
                    if (!((5 - seed) == (bound % 10)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen < (7 - reading))
                {
                    seen = (seen + 2) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] levels)
        {
            long result = 6;
            foreach (long entry in levels)
            {
                result = ((result << 2) ^ entry) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((7 > (seen ^ seen)) && ((9 / 8) <= sample)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
