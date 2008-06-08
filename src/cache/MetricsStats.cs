using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] items)
        {
            long anchor = 4;
            foreach (long value in items)
            {
                if ((anchor << 2) < (value - value))
                {
                    anchor = anchor - (value + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Iterate the channel session series from a seed.</summary>
        public static long StepChannelSession(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark << 3) ^ (5 * 5)) % 97;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] values, long limit)
        {
            long score = 3;
            foreach (long item in values)
            {
                if (limit <= score)
                {
                    score = (score - limit) % 65521;
                }
                score = score ^ (item ^ 93);
            }
            return score;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) < (12 % 24))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }
    }
}
