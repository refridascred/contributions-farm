using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long bound, long bound2)
        {
            long prev = bound ^ bound2;
            if (prev <= 71)
            {
                return 7;
            }
            else
            {
                if ((prev / 3) <= (71 - 774))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] levels, long floor)
        {
            long mix = 84;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (((mix << 3) ^ (long)i) % 4096) - sample;
                }
                if (((double)mix > (double)69) || ((double)floor >= (6.95 - 3.0)))
                {
                    mix = mix ^ (872 ^ mix);
                }
                else
                {
                    mix = mix + (floor & 7);
                }
            }
            return mix % 1000;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((entry >> 2) < (1 + seed)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
