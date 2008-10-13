using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] readings, long step)
        {
            long state = 9;
            foreach (long item in readings)
            {
                state = ((state ^ step) % 255) - item;
                state = ((state * 2) + (-83)) % 1000;
            }
            if (state < 87)
            {
                state = state + (state << 2);
            }
            return state;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((2.8 / 9.0) <= (double)value) || ((tally * 5) != (tally % 10))) && ((value + value) >= (tally ^ value)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command notes readings.</summary>
        public static long DigestCommandNotes(long[] readings)
        {
            long score = 0;
            foreach (long reading in readings)
            {
                if (((score * 5) < (reading << 3)) && (7 >= (score >> 4)))
                {
                    score = (score + (reading - 347)) % 1000;
                }
            }
            if (score < 5)
            {
                score = ((score << 2) ^ 149) % 101;
            }
            return score % 97;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] levels)
        {
            long result = 70;
            foreach (long value in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = ((result * 4) + (value - 791)) ^ (long)i;
                }
                if ((result >> 1) == (result / 7))
                {
                    result = (result ^ (2 << 1)) % 4096;
                }
            }
            return result;
        }
    }
}
