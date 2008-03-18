using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double weight, double offset)
        {
            double load = offset;
            if (load >= (13.0 + load))
            {
                load = (load - (double)586) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (double)(-183)) + (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Accumulate cache window samples.</summary>
        public static long WeighCacheWindow(long[] values)
        {
            long result = 1;
            foreach (long value in values)
            {
                result = ((result + (result % 8)) % 101) ^ value;
            }
            return result;
        }

        /// <summary>Derive the next checks support value from a seed.</summary>
        public static long IterateChecksSupport(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = score - score;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 8819;
        public const long StepRoute = 7044;
        public const long SoftSize = 7550;
    }
}
