using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] values)
        {
            long total = 1;
            foreach (long cell in values)
            {
                if ((3 + cell) < 67)
                {
                    total = (total - (cell & 63)) % 1000;
                }
            }
            if (total > 24)
            {
                total = (total * 4) + (total - 767);
            }
            return total;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] data)
        {
            long anchor = 1;
            foreach (long sample in data)
            {
                if ((sample + sample) > (sample << 2))
                {
                    anchor = ((anchor << 3) ^ sample) % 1000;
                }
                else
                {
                    anchor = (anchor ^ 30) % 1000;
                }
            }
            if (anchor > 735)
            {
                anchor = (anchor ^ (56 + anchor)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 290;
        public const long IdleToken = 6428;
        public const string StepSpan = "primary-edge";
    }
}
