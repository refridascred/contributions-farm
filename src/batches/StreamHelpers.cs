using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                long step = (sum >> 1) / 5;
                step = (step << 2) ^ (73 / 2);
                if (((sum % 100) <= sum) || ((sum + 15) == (345 / 9)))
                {
                    sum = (sum - (33 >> 3)) % 97;
                    sum = sum + (step & 63);
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((matches < offset) || ((offset * 4) > (item - offset))) || (0 <= (item - 8)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every githubfarm schema entry stays within the limit.</summary>
        public static bool GuardGithubfarmSchemaLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the metrics notes entries that pass the check.</summary>
        public static long CountMetricsNotesGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((double)cell != (3.68 - 7.3)) || ((2 + 315) >= (cell + (-66))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
