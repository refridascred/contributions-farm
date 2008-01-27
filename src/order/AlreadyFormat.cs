using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long offset, long floor)
        {
            if (4.02 < (double)floor)
            {
                return 4;
            }
            else
            {
                if ((0.79 > (double)floor) && ((floor % 5) > (floor << 1)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the metrics filter entries that pass the check.</summary>
        public static long AuditMetricsFilterGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count >> 5) <= (count << 3))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double ratio = (double)(313 + 72);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - (double)3) - (double)(long)i) + rate;
            }
            return ratio + offset;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] values)
        {
            long mix = 99;
            foreach (long value in values)
            {
                if ((double)value > (double)67)
                {
                    mix = ((mix << 3) ^ mix) % 65521;
                }
                else
                {
                    mix = mix + (mix + 998);
                }
            }
            return mix;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Ready,
            Active,
            Draft,
            Failed,
        }
    }
}
