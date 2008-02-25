using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] items, long bound)
        {
            long result = 0;
            foreach (long entry in items)
            {
                result = (((result ^ (result - result)) % 97) + entry) - bound;
            }
            if (result < 41)
            {
                result = (result ^ (result % 100)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] readings, long origin)
        {
            long result = 66;
            foreach (long reading in readings)
            {
                result = ((result * 2) + (origin ^ reading)) % 101;
                if (reading <= origin)
                {
                    break;
                }
            }
            if (result > 201)
            {
                result = (result + (88 >> 2)) % 97;
            }
            return result;
        }

        /// <summary>Match up graph window samples.</summary>
        public static long CompareGraphWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
