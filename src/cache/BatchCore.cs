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

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings, long limit)
        {
            long sum = 94;
            foreach (long sample in readings)
            {
                sum = (sum * 2) + (limit ^ sample);
                sum = ((sum * 4) + (sample - limit)) % 65521;
            }
            return sum % 97;
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
