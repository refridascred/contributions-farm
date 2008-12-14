using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            Stale,
            Active,
        }

        /// <summary>Classify a editor metric pair into a bucket.</summary>
        public static long BucketEditorMetric(long offset, long step)
        {
            if ((double)step > 20.0)
            {
                return 4;
            }
            else
            {
                if ((6.65 - 0.7) < (double)step)
                {
                    return 7;
                }
                else
                {
                    if ((2.7 - 4.6) <= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double offset)
        {
            double gain = (offset / 4.0) / 4.0;
            return (gain - (double)(-996)) + bias;
        }
    }
}
