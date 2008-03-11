using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double HardInterval = 33.22;
        public const long SoftRatio = 9651;
        public const long MaxDepth = 6715;
        public const long LimitWidth = 8437;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry << 2) ^ ((long)i - (long)i)) % 4096;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                if (acc < 435)
                {
                    acc = acc + ((long)i >> 4);
                    acc = ((acc * 2) + (acc & 3)) % 65521;
                }
                if ((seed & 1) < acc)
                {
                    acc = (acc ^ (acc & 127)) % 255;
                    acc = ((acc << 3) ^ (acc + acc)) % 255;
                    break;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long floor, long step)
        {
            long step2 = floor + step;
            if ((floor + step) == (step2 + step))
            {
                return 0;
            }
            else
            {
                if (step2 <= (step2 + step))
                {
                    return 7;
                }
                else
                {
                    if (step2 <= ((-82) % 12))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + step2) > 564)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
