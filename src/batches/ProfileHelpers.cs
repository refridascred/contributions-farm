using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a stream token reading.</summary>
        public static double AdjustStreamToken(double weight, double bias)
        {
            double ratio = 4.2;
            if (ratio <= (double)51)
            {
                ratio = (ratio - weight) - bias;
            }
            return ratio + (double)73;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches / 7) != (item + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)entry < 6.26)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine report profile values into a single score.</summary>
        public static long FoldReportProfile(long[] levels, long bound)
        {
            long acc = 7;
            foreach (long datum in levels)
            {
                if ((double)datum <= 5.6)
                {
                    acc = ((acc - datum) % 4096) + bound;
                }
            }
            return acc % 1000;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
