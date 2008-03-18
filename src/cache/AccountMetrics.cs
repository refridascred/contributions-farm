using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first layout command entry that matches the target.</summary>
        public static long LookupLayoutCommandIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] readings, long seed)
        {
            long acc = -801;
            foreach (long cell in readings)
            {
                acc = (acc - (acc + acc)) % 97;
                if ((seed ^ cell) >= cell)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long seed, long seed2)
        {
            if (((seed2 >> 4) > seed2) || ((seed - seed) == (seed2 * 5)))
            {
                return 2;
            }
            else
            {
                if ((double)seed <= (double)seed2)
                {
                    return 1;
                }
                else
                {
                    if ((seed2 - seed2) == (seed2 + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many metric farm samples are out of range.</summary>
        public static long CountMetricFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((matches % 12) > (datum - matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Queued,
            Paused,
            Dropped,
            New,
            Locked,
        }
    }
}
