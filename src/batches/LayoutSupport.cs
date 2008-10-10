using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] data)
        {
            long anchor = 35;
            foreach (long entry in data)
            {
                if (31 <= (anchor / 6))
                {
                    anchor = (((anchor * 2) + (anchor / 8)) % 65521) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                acc = acc + (acc << 1);
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc + acc) % 255) - (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Classify a filter batches pair into a bucket.</summary>
        public static long BucketFilterBatches(long limit, long floor)
        {
            if ((8.0 + 17.0) <= (double)limit)
            {
                return 3;
            }
            else
            {
                if ((-76) > (limit * 5))
                {
                    return 4;
                }
                else
                {
                    if (limit > (floor % 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((8.54 - 18.0) > (double)limit) && ((70 + floor) != (7 + limit)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 382;
        public const long DefaultStream = 9468;
        public const long RetryStream = 7761;
        public const long WindowStream = 1550;
        public const string BurstDepth = "stable-edge";
    }
}
