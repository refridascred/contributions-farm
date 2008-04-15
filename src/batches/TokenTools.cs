using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)tally >= (double)floor)
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Project the next notes editor value.</summary>
        public static double ProjectNotesEditor(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 <= (3.95 * 4.3))
            {
                rate2 = rate2 + (double)3;
            }
            else
            {
                rate2 = rate2 + (rate2 - rate2);
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 - (rate - rate2)) + (double)(long)i;
            }
            return rate2 + span;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Queued,
            Paused,
            Retry,
        }
    }
}
