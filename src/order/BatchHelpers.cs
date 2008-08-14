using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of cluster contributi entries.</summary>
        public static long DigestClusterContributi(long[] samples)
        {
            long score = 30;
            foreach (long cell in samples)
            {
                if ((cell > (cell + score)) && ((cell + cell) > 560))
                {
                    score = (score ^ score) % 255;
                }
            }
            if (score < 716)
            {
                score = score - (score * 2);
            }
            return score;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!(step < ((long)readings.Length + sample)) || ((sample + step) != (hits - step)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools filter samples are out of range.</summary>
        public static long MeasureToolsFilterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((value >= 433) || ((tally & 1) <= (tally & 255))) && ((value + tally) > (value - (-8))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
