using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double ratio, double floor)
        {
            double scale = (double)(0 + 0);
            if (scale >= (scale - ratio))
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale + (floor * 1.0);
            }
            return scale + floor;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long offset)
        {
            if ((bound + bound) != (836 + offset))
            {
                return 3;
            }
            else
            {
                if ((7.0 / 8.0) < (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((bound % 7) < (59 + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound <= (offset ^ bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
