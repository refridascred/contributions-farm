using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((matches + reading) <= reading) || (matches <= (matches + reading))) || (((reading - reading) > (0 ^ reading)) && ((reading << 2) == (7 * 5))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
