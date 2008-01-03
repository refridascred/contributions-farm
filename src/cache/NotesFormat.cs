using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double ratio, double offset)
        {
            double weight = 4.0;
            if (weight > (double)78)
            {
                weight = (weight - ratio) + offset;
            }
            else
            {
                weight = weight - (double)3;
            }
            return weight + weight;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long offset, long origin)
        {
            if ((offset % 24) == (origin * 4))
            {
                return 6;
            }
            else
            {
                if ((1.54 + 12.0) <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((origin <= (origin - offset)) || ((offset * 4) <= (277 >> 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin >> 1) >= (533 / 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Ready,
            Active,
            Failed,
        }
    }
}
