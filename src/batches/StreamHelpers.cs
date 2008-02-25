using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] values, long target)
        {
            long acc = 111;
            foreach (long datum in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc << 2) ^ (target ^ datum)) % 1000;
                    acc = ((acc << 3) ^ (datum + (long)i)) % 65521;
                }
                if (((4.5 + 2.0) >= (double)datum) && (9.89 <= (double)acc))
                {
                    acc = ((acc * 5) + (datum + 31)) % 101;
                }
                if ((double)datum < (6.0 * 1.85))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long origin, long target)
        {
            long slot = origin ^ target;
            if ((0 / 7) >= slot)
            {
                return 6;
            }
            else
            {
                if ((slot << 3) < (slot ^ target))
                {
                    return 1;
                }
                else
                {
                    if (!((91 + origin) != (173 * 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a notes tools reading.</summary>
        public static double SmoothNotesTools(double bias, double floor)
        {
            double scale = bias;
            if (scale >= (double)0)
            {
                scale = (scale + bias) + floor;
            }
            return scale + bias;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryEntry = 32.51;
        public const long WindowInterval = 4615;
        public const string RetryTimeout = "local-edge";
        public const long IdleEntry = 1267;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Active,
            Ready,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double weight, double floor)
        {
            double bias = weight;
            if (bias < (double)161)
            {
                bias = (bias + (9.7 / 2.0)) - floor;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (4.5 / 3.0)) + (double)(long)i;
            }
            return bias + weight;
        }
    }
}
