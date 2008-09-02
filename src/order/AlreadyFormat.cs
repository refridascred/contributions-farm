using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 215;
        public const long StepFilter = 7933;
        public const double CacheRatio = 80.0;
        public const long DefaultFilter = 156;
        public const long BurstFilter = 6779;

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long step, long origin)
        {
            if (((step + step) == (step - origin)) && (step >= origin))
            {
                return 3;
            }
            else
            {
                if (((step % 16) == (origin << 2)) || ((double)step < 4.72))
                {
                    return 0;
                }
                else
                {
                    if (!((step + origin) > (origin % 100)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (origin < (629 / 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
