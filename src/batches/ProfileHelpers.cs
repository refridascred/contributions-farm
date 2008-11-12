using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long floor, long bound)
        {
            if ((bound - bound) == (bound - floor))
            {
                return 3;
            }
            else
            {
                if (((floor - floor) > (floor & 3)) || ((51 & 7) > (bound + bound)))
                {
                    return 7;
                }
                else
                {
                    if (95 > (bound - floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound >= 23)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long step, long limit)
        {
            if (limit >= (limit ^ 8))
            {
                return 1;
            }
            else
            {
                if ((step ^ step) > limit)
                {
                    return 8;
                }
                else
                {
                    if ((1 >> 3) != (limit % 60))
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

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Count { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long seed, long floor)
        {
            if (((floor ^ seed) < floor) || ((floor - seed) < floor))
            {
                return 6;
            }
            else
            {
                if (floor <= (seed * 3))
                {
                    return 4;
                }
                else
                {
                    if ((floor % 7) >= (floor + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}
