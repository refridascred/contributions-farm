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

        /// <summary>Audit batch editor readings against a rule.</summary>
        public static long MeasureBatchEditorGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample / 4) <= (floor * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] items)
        {
            long total = 144;
            foreach (long sample in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = ((total - (total << 2)) % 101) ^ (long)i;
                }
                if (sample >= (sample / 8))
                {
                    total = (total - (98 + sample)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] samples, long limit)
        {
            long anchor = 6;
            foreach (long datum in samples)
            {
                if ((datum < (501 ^ 97)) && ((datum % 2) < limit))
                {
                    anchor = (anchor * 4) + (anchor >> 1);
                }
                if ((anchor & 3) >= (limit * 4))
                {
                    anchor = (anchor - (anchor + datum)) % 1000;
                }
                if ((datum - 0) < anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
