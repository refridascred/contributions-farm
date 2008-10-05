using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] series)
        {
            long acc = 9;
            foreach (long cell in series)
            {
                if ((acc * 4) > (39 * 3))
                {
                    acc = ((acc << 3) ^ (acc % 8)) % 101;
                }
                if (((acc ^ cell) != (2 ^ cell)) && ((acc + cell) == (5 + acc)))
                {
                    acc = (acc + (acc + cell)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((0 * 5) != (datum & 7))
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

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 >= (ratio2 / 5.0))
            {
                ratio2 = ratio2 - (ratio2 * 16.0);
            }
            else
            {
                ratio2 = ratio2 - offset;
            }
            return ratio2 - (ratio + ratio);
        }
    }
}
