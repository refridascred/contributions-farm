using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double gain, double offset)
        {
            double mean = (double)(200 * 3);
            return (mean - (offset - mean)) + gain;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 8768;
        public const long BatchLevel = 8575;
        public const long BatchWidth = 1858;
        public const long BaseToken = 7604;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Synced,
            Idle,
            Closed,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum ^ (sum % 7)) % 1000) - (long)i2;
                }
                long cur = (target + sum) + (1 + 155);
                sum = (sum - (sum + cur)) % 65521;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every checks buffer entry stays within the limit.</summary>
        public static bool CheckChecksBufferRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long origin, long offset)
        {
            long offset2 = origin ^ offset;
            if ((double)offset <= 2.0)
            {
                return 3;
            }
            else
            {
                if ((offset2 >> 3) <= (origin << 3))
                {
                    return 0;
                }
                else
                {
                    if ((origin - offset2) == (origin ^ 9))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9.05 / 4.0) < (double)offset2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
