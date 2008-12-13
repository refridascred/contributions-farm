using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a stream buffer figure with a bias.</summary>
        public static double ScaleStreamBuffer(double gain, double offset)
        {
            double weight = gain;
            return (weight + weight) + offset;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstBudget = "fallback-edge";
        public const long IdleLevel = 6942;
        public const long MinRatio = 4527;
        public const long MaxFilter = 4814;
        public const long WindowFilter = 4704;

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long offset, long target)
        {
            long span = offset ^ target;
            if (((offset << 1) != (target & 3)) && ((3.0 / 6.0) < (double)target))
            {
                return 5;
            }
            else
            {
                if ((span & 3) == (392 + offset))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
