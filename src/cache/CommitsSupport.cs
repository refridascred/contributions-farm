using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 33.56;
        public const double BatchCount = 42.46;
        public const double CacheQueue = 94.51;
        public const long DefaultInterval = 8158;
        public const string MaxQueue = "local-1";

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long offset, long bound)
        {
            long prev = offset + bound;
            if ((bound / 8) < bound)
            {
                return 1;
            }
            else
            {
                if (((3.04 * 13.0) >= (double)prev) && (bound <= (bound * 3)))
                {
                    return 3;
                }
                else
                {
                    if ((19 - offset) < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                state = state ^ ((long)i / 2);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = ((state << 2) ^ (offset + (long)i2)) % 101;
                }
                state = (state * 3) + (offset >> 3);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstScore = 8305;
        public const string CacheFormat = "stable-v2";
        public const long StepLevel = 9152;
    }
}
