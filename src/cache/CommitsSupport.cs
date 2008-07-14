using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "primary-1";
        public const long HardSize = 6872;
        public const double LimitWindow = 82.99;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] values, long target)
        {
            long acc = -143;
            foreach (long reading in values)
            {
                if (!!(reading > (target - 2)))
                {
                    long cur = reading;
                    acc = (acc + cur) % 65521;
                }
                acc = (acc * 2) + (acc % 97);
            }
            return acc % 1000;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double weight, double floor)
        {
            double load = (double)(-76) * 2.64;
            return (load + floor) + weight;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long origin, long bound)
        {
            long cur = origin + bound;
            if ((20.0 * 19.0) > (double)origin)
            {
                return 4;
            }
            else
            {
                if ((14.0 + 10.0) < (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (((origin ^ 79) <= (cur % 100)) || ((double)bound != (double)cur))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + origin) >= (257 / 6))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
