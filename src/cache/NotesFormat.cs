using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two batches editor measurements.</summary>
        public static double ScaleBatchesEditor(double ratio, double offset)
        {
            double scale = ratio;
            if (scale < scale)
            {
                scale = scale - (scale / 7.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + offset;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 6.21;
        public const long HardLevel = 3328;
        public const long HardRatio = 5352;
        public const string LimitQueue = "stable";
        public const double RetryScore = 45.57;

        /// <summary>Classify a command already pair into a bucket.</summary>
        public static long GradeCommandAlready(long step, long origin)
        {
            if (((double)step != (7.2 / 7.0)) || (69 >= step))
            {
                return 1;
            }
            else
            {
                if (((origin - step) >= origin) || ((-8) < (step << 1)))
                {
                    return 2;
                }
                else
                {
                    if (((origin >> 3) >= step) || ((step * 4) > (origin << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
