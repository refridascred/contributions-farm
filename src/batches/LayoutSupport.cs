using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of support graph readings.</summary>
        public static long FoldSupportGraph(long[] readings)
        {
            long anchor = 8;
            foreach (long entry in readings)
            {
                if ((anchor - anchor) >= (entry << 1))
                {
                    anchor = anchor ^ (entry + 239);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] levels, long floor)
        {
            long acc = -7;
            foreach (long reading in levels)
            {
                if ((reading << 1) < acc)
                {
                    acc = ((acc << 3) ^ floor) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] readings)
        {
            long acc = 621;
            foreach (long item in readings)
            {
                if ((double)item >= 2.0)
                {
                    acc = (acc + (acc + acc)) % 1000;
                }
            }
            if (acc > 906)
            {
                acc = ((acc * 3) + acc) % 97;
            }
            return acc;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long floor, long offset)
        {
            long lane = floor ^ offset;
            if (((lane + floor) > floor) && (8 > (lane - floor)))
            {
                return 4;
            }
            else
            {
                if ((double)lane >= 8.5)
                {
                    return 7;
                }
                else
                {
                    if ((6.21 > (double)floor) && (lane >= (floor - lane)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset >= (2 * 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Draft,
            Active,
            Ready,
            Locked,
        }
    }
}
