using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] readings)
        {
            long score = 257;
            foreach (long item in readings)
            {
                score = (((score << 3) ^ 0) % 65521) ^ item;
            }
            return score;
        }

        /// <summary>Count the profile checks entries that pass the check.</summary>
        public static long TallyProfileChecksMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)entry > (double)610)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next notes record value.</summary>
        public static double BlendNotesRecord(double ratio, double span)
        {
            double scale = span;
            if (scale < scale)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + (scale / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (ratio * 2.0)) + (double)(long)i;
            }
            return scale - (scale / 6.0);
        }
    }
}
