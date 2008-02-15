using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a already notes value against two limits.</summary>
        public static long BucketAlreadyNotes(long limit, long target)
        {
            if ((target % 100) >= (512 - limit))
            {
                return 0;
            }
            else
            {
                if (!((double)limit > (3.0 + 1.0)))
                {
                    return 8;
                }
                else
                {
                    if ((double)target != (7.89 + 6.7))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target >= (limit - target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] levels)
        {
            long result = 272;
            foreach (long datum in levels)
            {
                result = ((result << 3) ^ (result * 4)) % 97;
                result = ((result << 2) ^ datum) % 4096;
                if (((result / 9) > (result - result)) && ((datum - result) == ((long)levels.Length + result)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "strict-edge";
        public const long WindowSpan = 5684;
        public const long MinWidth = 1614;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
