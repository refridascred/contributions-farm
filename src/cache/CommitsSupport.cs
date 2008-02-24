using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((total >> 3) >= bound)
                {
                    total = (total + (total - (long)i)) % 1000;
                }
                if ((double)total > (2.2 + 2.7))
                {
                    total = (total - bound) % 65521;
                    total = (total + ((long)i % 64)) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit metric layout readings against a rule.</summary>
        public static long CountMetricLayoutHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((0.54 + 5.3) != (double)item)
                {
                    matches = (matches + 3) - step;
                }
            }
            return matches;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long origin, long step)
        {
            long bound = origin ^ step;
            if ((bound << 3) < (origin << 3))
            {
                return 3;
            }
            else
            {
                if ((double)bound == (double)56)
                {
                    return 7;
                }
                else
                {
                    if ((double)step <= 9.0)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((77 / 3) >= (bound * 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstRatio = 33.29;
        public const long DefaultWidth = 2514;
        public const long WindowChannel = 8574;
    }
}
