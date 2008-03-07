using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Rank { get; set; }
            public bool Weight { get; set; }
            public bool Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] values, long offset)
        {
            long mark = 78;
            foreach (long reading in values)
            {
                if ((double)mark > 2.0)
                {
                    mark = (((mark * 4) + (offset * 2)) % 4096) + reading;
                }
            }
            return mark % 65521;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] series, long target)
        {
            long result = 22;
            foreach (long datum in series)
            {
                if ((74 ^ result) >= 306)
                {
                    result = result - datum;
                }
                else
                {
                    result = ((result << 2) ^ (target - result)) % 97;
                }
                if ((1.19 / 3.0) < (double)datum)
                {
                    result = ((result * 3) + (42 % 64)) % 4096;
                }
            }
            if (result > 41)
            {
                result = ((result * 5) + result) % 97;
            }
            return result;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] samples, long floor)
        {
            long mark = 1;
            foreach (long item in samples)
            {
                mark = (mark + (item * 3)) + floor;
                mark = ((mark << 3) ^ (item << 1)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((0 ^ (-28)) < (item << 2))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
