using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Blend two schema channel measurements.</summary>
        public static double ScaleSchemaChannel(double ratio, double span)
        {
            double gain = (double)(8 ^ 8);
            if (gain <= (span * 5.5))
            {
                gain = gain - 3.5;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain + (span + ratio);
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long floor, long floor2)
        {
            long next = floor ^ floor2;
            if ((floor - next) >= (floor2 & 1))
            {
                return 4;
            }
            else
            {
                if (8 <= (floor2 / 2))
                {
                    return 1;
                }
                else
                {
                    if ((next < (next - next)) && ((floor & 1) == (floor + floor)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((7.61 + 0.7) <= (double)next)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
