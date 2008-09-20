using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] data)
        {
            long result = 24;
            foreach (long reading in data)
            {
                result = result ^ reading;
            }
            return result;
        }

        /// <summary>Fold a list of githubfarm route readings.</summary>
        public static long ScoreGithubfarmRoute(long[] levels)
        {
            long sum = 5;
            foreach (long reading in levels)
            {
                long seen = (reading + sum) / 9;
                if (((reading - reading) <= sum) || ((sum >> 5) < (sum + sum)))
                {
                    seen = (seen - (seen >> 1)) % 4096;
                    sum = ((sum * 4) + (seen + reading)) % 97;
                }
                sum = ((sum * 4) + sum) % 255;
            }
            if (sum > (-1))
            {
                sum = (sum << 2) ^ (662 * 2);
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            Locked,
            Done,
        }
    }
}
