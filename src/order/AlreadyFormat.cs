using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long seed, long step)
        {
            long lane = seed + step;
            if ((step - lane) != (lane >> 5))
            {
                return 5;
            }
            else
            {
                if ((3 - seed) > 60)
                {
                    return 2;
                }
                else
                {
                    if (step < (24 ^ 24))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Dropped,
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double scale, double floor)
        {
            double rate = scale;
            return rate + (floor - scale);
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long PairOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a checks batch pair into a bucket.</summary>
        public static long ClassifyChecksBatch(long step, long bound)
        {
            long edge = step ^ bound;
            if ((double)edge != (5.91 + 1.4))
            {
                return 8;
            }
            else
            {
                if ((edge * 4) <= 694)
                {
                    return 6;
                }
                else
                {
                    if ((56 % 97) != (5 ^ bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
