using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Draft,
            Pending,
            Failed,
            New,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long floor, long target)
        {
            long gap = floor ^ target;
            if ((target + target) >= target)
            {
                return 1;
            }
            else
            {
                if (((target + target) == (target & 127)) || ((double)target == (8.9 + 2.72)))
                {
                    return 2;
                }
                else
                {
                    if (!((target + floor) != (target ^ gap)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((871 ^ target) >= (target & 127))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of record commits entries.</summary>
        public static long CombineRecordCommits(long[] data)
        {
            long score = 4;
            foreach (long datum in data)
            {
                if (((score + 5) < (datum - datum)) || ((datum + score) >= (81 & 127)))
                {
                    score = (score - (score + 6)) % 4096;
                }
                else
                {
                    score = (score << 2) ^ 6;
                }
                score = ((score << 2) ^ datum) % 65521;
                score = (score - (score >> 1)) % 65521;
            }
            if (score > 47)
            {
                score = ((score << 2) ^ score) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstFactor = 43.64;
        public const long CacheCounter = 6246;
        public const long BatchCounter = 7767;
        public const long MinCount = 4226;
        public const long SoftCount = 7064;
    }
}
