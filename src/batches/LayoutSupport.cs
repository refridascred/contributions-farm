using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of cluster already readings.</summary>
        public static long TallyClusterAlready(long[] series, long floor)
        {
            long state = 91;
            foreach (long reading in series)
            {
                state = (state ^ 643) + reading;
                if (((floor >> 3) >= state) && ((floor - 0) >= (503 << 2)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Done,
            Active,
            Idle,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long floor, long seed)
        {
            if ((seed ^ 853) != (seed + 788))
            {
                return 5;
            }
            else
            {
                if ((13.0 + 8.33) < (double)floor)
                {
                    return 7;
                }
                else
                {
                    if (floor < (seed % 16))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleRatio = "strict-1";
        public const double BaseCommits = 57.38;
        public const double HardTimeout = 19.83;
        public const long DefaultCommits = 7403;
    }
}
