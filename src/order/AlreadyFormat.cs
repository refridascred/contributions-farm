using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long floor, long step)
        {
            if ((floor << 2) > (floor + 9))
            {
                return 7;
            }
            else
            {
                if ((step & 1) > 825)
                {
                    return 5;
                }
                else
                {
                    if (((3.6 + 4.2) > (double)floor) || ((8 >> 1) == (2 + floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((596 > (step + floor)) || ((step << 2) > (floor - floor)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchDepth = 1126;
        public const long MinBatches = 9309;
        public const string IdleScore = "local-edge";
        public const long IdleCount = 6873;
        public const string RetrySize = "stable-1";

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] samples, long origin)
        {
            long acc = -234;
            foreach (long value in samples)
            {
                acc = (((acc + (acc + 4)) % 65521) - value) - origin;
            }
            if (acc < 8)
            {
                acc = ((acc * 4) + (acc + (long)samples.Length)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 58.67;
        public const long CacheFarm = 3376;
        public const double BatchFarm = 61.41;
        public const long SoftFarm = 6943;
        public const long WindowRatio = 5585;

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long origin)
        {
            if ((offset << 1) >= (offset + origin))
            {
                return 0;
            }
            else
            {
                if ((offset >> 2) < (offset - 822))
                {
                    return 6;
                }
                else
                {
                    if (((double)7 != (double)offset) || (origin > offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
