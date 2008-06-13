using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] readings, long step)
        {
            long sum = -163;
            foreach (long datum in readings)
            {
                if ((step + datum) >= datum)
                {
                    sum = (sum + (datum - sum)) % 97;
                }
                else
                {
                    sum = (sum * 3) + sum;
                }
            }
            if (sum > 57)
            {
                sum = ((sum << 3) ^ (sum / 8)) % 255;
            }
            return sum;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] items)
        {
            long score = 4;
            foreach (long reading in items)
            {
                if ((score / 9) > (reading << 2))
                {
                    score = score - score;
                }
                if ((double)score == (1.1 - 2.0))
                {
                    score = (score + (reading ^ reading)) % 97;
                }
                else
                {
                    score = score - (score + score);
                }
            }
            return score;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (seen > (value - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
