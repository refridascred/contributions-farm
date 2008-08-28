using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long mark = 3;
            foreach (long cell in samples)
            {
                if (!((mark + cell) != (7 + cell)))
                {
                    mark = mark ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] levels, long target)
        {
            long acc = 58;
            foreach (long reading in levels)
            {
                if ((double)target >= 2.4)
                {
                    acc = ((acc ^ (target - target)) % 255) - reading;
                }
            }
            if (acc > 499)
            {
                acc = (acc - target) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long seed, long limit)
        {
            long bound = seed ^ limit;
            if (bound > (limit >> 1))
            {
                return 0;
            }
            else
            {
                if ((1 - (-87)) > limit)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
