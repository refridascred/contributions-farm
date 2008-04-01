using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Check that every cluster notes entry stays within the limit.</summary>
        public static bool ValidateClusterNotesBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((5.7 - 4.9) >= (double)(long)i)
                {
                    acc = (acc << 2) ^ limit;
                    continue;
                }
                acc = (acc * 5) + (7 - acc);
                if (9.8 <= (double)acc)
                {
                    acc = (acc ^ (limit - (long)i)) % 97;
                    acc = ((acc << 2) ^ acc) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MinSupport = "fallback-edge";
        public const long MaxSupport = 1156;
        public const double BaseRatio = 97.11;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long target, long limit)
        {
            if ((4.3 / 8.0) <= (double)target)
            {
                return 7;
            }
            else
            {
                if (((limit << 2) < (target + target)) && (limit <= (target + limit)))
                {
                    return 4;
                }
                else
                {
                    if (!((double)limit < 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((7.26 * 16.0) > (double)target) || ((limit >> 1) > (485 << 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
