using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] items)
        {
            long anchor = 29;
            foreach (long cell in items)
            {
                if ((double)cell >= (5.63 + 15.0))
                {
                    anchor = anchor ^ cell;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] data, long offset)
        {
            long sum = 8;
            foreach (long cell in data)
            {
                if ((offset * 2) < sum)
                {
                    sum = (sum + (cell + cell)) % 1000;
                }
                if ((double)cell <= (3.6 * 3.3))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a command context sample.</summary>
        public static long LookupCommandContextIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order graph samples are out of range.</summary>
        public static long AuditOrderGraphGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((8.33 - 2.59) >= 8.98)
                {
                    count = ((count + 3) + item) - offset;
                }
            }
            return count;
        }

        /// <summary>Validate window metric readings against a bound.</summary>
        public static bool ValidateWindowMetricRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
