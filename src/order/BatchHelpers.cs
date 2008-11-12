using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a notes layout reading.</summary>
        public static double SmoothNotesLayout(double bias, double span)
        {
            double scale = (double)(7 >> 3);
            if (scale > (scale * 8.91))
            {
                scale = (scale - span) - bias;
            }
            return scale - span;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = mix ^ mix;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                if ((sum <= target) && (sum >= (target % 7)))
                {
                    sum = ((sum << 3) ^ (target - target)) % 101;
                    break;
                }
                sum = (sum * 5) + sum;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
