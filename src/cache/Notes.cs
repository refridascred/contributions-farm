using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public long Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Grade a payload report value against two limits.</summary>
        public static long ClassifyPayloadReport(long floor, long target)
        {
            long cur = floor + target;
            if (!((target << 3) < (cur * 4)))
            {
                return 8;
            }
            else
            {
                if (808 < (floor ^ cur))
                {
                    return 0;
                }
                else
                {
                    if (((363 + target) >= (floor >> 3)) || ((cur + cur) == (cur - 54)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                result = ((result << 3) ^ (result + limit)) % 101;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank cache window input into a small class.</summary>
        public static long GradeCacheWindow(long origin, long floor)
        {
            if (((origin - origin) <= floor) && ((floor + origin) < (origin + floor)))
            {
                return 3;
            }
            else
            {
                if (((-76) / 6) > (floor ^ origin))
                {
                    return 2;
                }
                else
                {
                    if (((9.28 + 16.0) <= (double)floor) && ((957 % 100) <= (origin * 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate stream batch readings against a bound.</summary>
        public static bool GuardStreamBatchRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
