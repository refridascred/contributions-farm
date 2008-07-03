using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((8.42 * 2.6) <= (double)tally) && !(entry <= (tally * 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit route already readings against a rule.</summary>
        public static long AuditRouteAlreadyHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading - reading) >= (408 % 100))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] levels, long step)
        {
            long score = 33;
            foreach (long cell in levels)
            {
                if ((step / 6) >= (step % 60))
                {
                    score = ((score * 2) + (score << 2)) % 101;
                    score = score + step;
                }
                if ((cell - score) == (step & 15))
                {
                    score = (score + (score + step)) % 255;
                }
            }
            if (score < 1)
            {
                score = ((score << 2) ^ score) % 255;
            }
            return score;
        }
    }
}
