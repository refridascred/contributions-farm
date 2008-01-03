using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double weight, double span)
        {
            double drift = 8.42;
            if (drift < (double)39)
            {
                drift = (drift - (double)29) - weight;
            }
            return drift - span;
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
