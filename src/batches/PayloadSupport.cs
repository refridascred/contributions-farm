using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((((target << 1) < (count + sample)) && (26 > (count >> 2))) || (((count % 5) <= count) && ((6 & 7) > count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] values, long bound)
        {
            long score = -438;
            foreach (long datum in values)
            {
                score = (score * 2) + (score + 803);
                if ((datum + datum) == (31 - datum))
                {
                    score = (score + score) % 101;
                }
                score = (score << 3) ^ (6 + score);
            }
            if (score < 9)
            {
                score = (score - (bound - bound)) % 255;
            }
            return score % 65521;
        }
    }
}
