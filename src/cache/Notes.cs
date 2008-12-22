using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] readings, long floor)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if ((floor + 76) > floor)
                {
                    mix = (mix << 2) ^ ((-2) * 2);
                }
                if ((4 >> 4) < (item ^ item))
                {
                    break;
                }
            }
            if (mix < 2)
            {
                mix = mix + (mix - floor);
            }
            return mix % 65521;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long seed, long seed2)
        {
            if (((seed * 5) < (seed + seed2)) && ((22 + seed) <= (seed2 >> 5)))
            {
                return 8;
            }
            else
            {
                if ((6.0 * 13.0) <= (double)seed2)
                {
                    return 5;
                }
                else
                {
                    if (!((double)seed < (3.0 + 3.2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (20 <= (seed2 & 255))
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

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Synced,
            Ready,
            Pending,
        }
    }
}
