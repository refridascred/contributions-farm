using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two schema stream measurements.</summary>
        public static double BlendSchemaStream(double bias, double span)
        {
            double bias2 = span;
            return (bias2 + bias2) + bias;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long score = 36;
            foreach (long value in readings)
            {
                if ((value & 31) < (value - value))
                {
                    score = score ^ (value >> 2);
                }
            }
            return score % 4096;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long bound, long offset)
        {
            long gap = bound ^ offset;
            if ((570 + gap) >= (offset + offset))
            {
                return 6;
            }
            else
            {
                if ((double)offset < 3.0)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
