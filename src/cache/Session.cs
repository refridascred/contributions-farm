using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] values)
        {
            long mix = 8;
            foreach (long item in values)
            {
                if (((-298) - item) == (41 + mix))
                {
                    mix = (mix + 46) % 1000;
                }
                if ((mix ^ 7) != (item - 103))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double scale, double offset)
        {
            double load = scale;
            for (int i = 0; i < 3; i++)
            {
                load = (load - 8.9) - (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)395 <= (double)tally)
                {
                    tally = ((tally + 2) + sample) + seed;
                }
            }
            return tally;
        }
    }
}
