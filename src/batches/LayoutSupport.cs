using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((5.4 - 4.1) <= (double)(long)i) && ((0.84 - 19.0) == (double)mix))
                {
                    mix = ((mix << 2) ^ (mix / 2)) % 65521;
                }
                else
                {
                    mix = mix - (bound >> 4);
                }
                mix = mix - (long)i;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
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
