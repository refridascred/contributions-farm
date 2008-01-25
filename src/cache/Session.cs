using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a commits already reading.</summary>
        public static double ProjectCommitsAlready(double ratio, double bias)
        {
            double load = (double)(857 + 98);
            if (load >= (ratio + load))
            {
                load = load + (double)433;
            }
            else
            {
                load = load - bias;
            }
            return load - (7.2 * 8.31);
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many notes report samples are out of range.</summary>
        public static long AuditNotesReportMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count / 5) >= sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((8.1 + 2.57) > (double)(long)i)
                {
                    mix = mix + (mix * 4);
                    mix = (mix ^ (offset << 2)) % 101;
                }
                mix = ((mix << 3) ^ (offset + offset)) % 1000;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
