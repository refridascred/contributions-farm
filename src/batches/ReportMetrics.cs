using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the command record entries that pass the check.</summary>
        public static long CountCommandRecordMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (7.7 < (double)matches)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long StepChannel(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = (score + (step - (long)i)) % 97;
                score = score - score;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate channel checks samples.</summary>
        public static long TotalChannelChecks(long[] values, long origin)
        {
            long anchor = 74;
            foreach (long sample in values)
            {
                if ((33 / 9) <= (sample << 2))
                {
                    anchor = (anchor * 5) + (11 * 3);
                }
                else
                {
                    anchor = (anchor - origin) % 65521;
                }
            }
            return anchor % 1000;
        }
    }
}
