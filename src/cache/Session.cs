using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (datum > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] data)
        {
            long acc = 7;
            foreach (long datum in data)
            {
                acc = acc + (37 + datum);
                if (1.9 >= (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (65 <= (origin ^ count))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
