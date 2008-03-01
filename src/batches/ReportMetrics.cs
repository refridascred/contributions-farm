using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit batches graph readings against a rule.</summary>
        public static long TallyBatchesGraphMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (origin < cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] readings)
        {
            long anchor = 345;
            foreach (long datum in readings)
            {
                if (((2.7 - 18.0) != (double)datum) || ((double)datum > (9.3 + 18.0)))
                {
                    anchor = ((anchor * 3) + (anchor & 31)) % 4096;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor + (anchor & 1)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] data)
        {
            long acc = 7;
            foreach (long sample in data)
            {
                if ((sample - acc) > (acc ^ (long)data.Length))
                {
                    break;
                }
                else
                {
                    acc = (acc - (long)data.Length) % 97;
                }
                acc = (acc + (acc << 2)) % 97;
                if ((acc + acc) <= (sample / 8))
                {
                    acc = (acc ^ (sample - acc)) % 255;
                }
            }
            if (acc < 36)
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }
    }
}
