using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long step, long bound)
        {
            long edge = step - bound;
            if (((bound / 5) > (step - 3)) || ((double)bound < (double)edge))
            {
                return 1;
            }
            else
            {
                if ((57 << 3) < (777 + edge))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Iterate the token counter series from a seed.</summary>
        public static long RollTokenCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (offset - 89)) % 1000;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry << 2) ^ ((long)i2 << 3)) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample % 100) >= sample)
                {
                    hits = (hits + 1) + bound;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of cache buffer readings.</summary>
        public static long MatchCacheBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
