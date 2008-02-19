using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double gain, double offset)
        {
            double ratio = gain;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + offset) - (double)(long)i;
            }
            return ratio - (offset * 9.65);
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long target, long limit)
        {
            if (!(target >= (limit + limit)))
            {
                return 8;
            }
            else
            {
                if ((295 + limit) == (limit << 1))
                {
                    return 3;
                }
                else
                {
                    if (((0.6 / 4.0) >= (double)limit) && ((double)target != (15.0 * 3.8)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally - 7) != (tally + (long)readings.Length))
                {
                    tally = ((tally + 1) ^ cell) + offset;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a command account sample.</summary>
        public static long FindCommandAccountIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
