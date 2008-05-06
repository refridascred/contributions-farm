using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next checks notes value from a seed.</summary>
        public static long RollChecksNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = total + (limit - (long)i);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a farm editor value against two limits.</summary>
        public static long BucketFarmEditor(long bound, long origin)
        {
            if ((714 + (-73)) >= (origin % 8))
            {
                return 8;
            }
            else
            {
                if ((origin * 2) <= (85 - bound))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin <= (4.0 + 6.1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxFactor = "primary-v2";
        public const double DefaultLayout = 31.25;
        public const string BatchLayout = "alpha-edge";
    }
}
