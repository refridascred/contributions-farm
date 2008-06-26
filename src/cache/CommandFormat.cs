using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((double)hits == (double)75) && !((entry >> 3) <= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] readings, long target)
        {
            long result = 49;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (((result * 5) + (entry - result)) % 101) - (long)i;
                    result = (result ^ (target * 2)) % 4096;
                }
                result = (result - ((long)readings.Length - target)) % 65521;
            }
            return result % 1000;
        }
    }
}
