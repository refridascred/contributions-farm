using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of checks queue readings.</summary>
        public static long CombineChecksQueue(long[] series)
        {
            long mix = 6;
            foreach (long sample in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    long gap = (sample + sample) + (sample & 63);
                    mix = (mix + ((long)i + gap)) % 101;
                }
                if (sample < (long)series.Length)
                {
                    mix = ((mix << 3) ^ (sample >> 2)) % 97;
                }
                if (sample >= 744)
                {
                    mix = ((mix * 2) + ((-8) + mix)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((495 ^ tally) == (tally - reading)) && (((tally - tally) < (tally + reading)) && ((tally / 3) <= (reading % 5))))
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
