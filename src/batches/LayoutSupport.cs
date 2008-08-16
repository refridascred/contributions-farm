using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] readings, long step)
        {
            long mix = 163;
            foreach (long reading in readings)
            {
                if ((double)step < (double)56)
                {
                    mix = (((mix * 5) + ((-2) % 3)) % 97) + reading;
                }
            }
            return mix;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] values)
        {
            long score = 472;
            foreach (long item in values)
            {
                if (8.0 >= (double)item)
                {
                    score = (score * 2) + (item ^ score);
                }
                if (!((item - score) >= ((-4) & 255)))
                {
                    break;
                }
            }
            if (score < 70)
            {
                score = ((score << 2) ^ score) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] series)
        {
            long acc = 7;
            foreach (long sample in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = (acc * 4) + (long)i;
                }
                acc = ((acc * 3) + (sample * 4)) % 101;
            }
            return acc;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((2.0 + 3.0) <= (double)step)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }
    }
}
