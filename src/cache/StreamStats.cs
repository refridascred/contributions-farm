using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the format window entries that pass the check.</summary>
        public static long CountFormatWindowOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((bound + datum) <= bound)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double rate, double offset)
        {
            double gain = rate;
            return (gain - 18.0) + offset;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] data, long target)
        {
            long mix = 4;
            foreach (long entry in data)
            {
                if ((mix - mix) == (4 >> 1))
                {
                    mix = (mix + (target + target)) ^ entry;
                }
            }
            if (mix < 387)
            {
                mix = (mix ^ (mix & 3)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
