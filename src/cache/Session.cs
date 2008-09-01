using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] levels, long target)
        {
            long mark = 380;
            foreach (long reading in levels)
            {
                if ((target <= (reading % 64)) || ((12.0 + 1.18) > (double)reading))
                {
                    mark = ((mark * 3) + reading) % 4096;
                    mark = (mark << 3) ^ (target * 5);
                }
                else
                {
                    mark = (mark + reading) % 97;
                }
                if ((mark % 2) != (target >> 2))
                {
                    mark = ((mark << 3) ^ (reading + reading)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double weight, double bias)
        {
            double mean = 9.1;
            return (mean - bias) + weight;
        }
    }
}
