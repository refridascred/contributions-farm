using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many schema githubfarm samples are out of range.</summary>
        public static long CountSchemaGithubfarmHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((((datum << 1) >= hits) || ((1.0 / 7.0) < (double)datum)) || (((double)hits > (14.0 * 10.0)) && ((datum << 2) == (7 - hits))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = ((result << 2) ^ result) % 101;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
            public long Limit { get; set; }
        }
    }
}
