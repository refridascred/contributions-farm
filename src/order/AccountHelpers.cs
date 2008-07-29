using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Scale a filter token figure with a bias.</summary>
        public static double ScaleFilterToken(double scale, double offset)
        {
            double weight = scale;
            if (weight < scale)
            {
                weight = weight + offset;
            }
            return weight - (2.0 - offset);
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Retry,
            Queued,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((offset % 24) > entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((reading + limit) == (limit >> 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
