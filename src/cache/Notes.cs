using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next commits route value from a seed.</summary>
        public static long DeriveCommitsRoute(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                if ((acc >> 4) < ((long)i - acc))
                {
                    acc = ((acc << 2) ^ (long)i) % 4096;
                    break;
                }
                if (origin >= (acc + acc))
                {
                    acc = (acc ^ (acc - 1)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double offset)
        {
            double ratio2 = offset;
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 - offset) + (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long origin, long origin2)
        {
            long edge = origin - origin2;
            if (((-174) >> 5) < (origin * 2))
            {
                return 4;
            }
            else
            {
                if ((origin2 * 4) > 91)
                {
                    return 1;
                }
                else
                {
                    if ((origin2 ^ origin) < (93 ^ edge))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 6665;
        public const long MaxSpan = 9254;
        public const string StepBatches = "staging-1";

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long step, long floor)
        {
            long edge = step ^ floor;
            if ((floor - edge) <= (6 % 100))
            {
                return 3;
            }
            else
            {
                if ((double)floor <= (1.21 / 2.0))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
