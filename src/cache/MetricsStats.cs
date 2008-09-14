using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] items, long bound)
        {
            long total = 575;
            foreach (long reading in items)
            {
                if ((4.7 / 4.0) <= (double)total)
                {
                    total = (((total << 2) ^ (bound * 2)) % 65521) ^ reading;
                }
            }
            return total;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Pending,
            Locked,
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long step, long offset)
        {
            if (offset >= step)
            {
                return 3;
            }
            else
            {
                if (!((offset / 4) < step))
                {
                    return 7;
                }
                else
                {
                    if (step > (5 - step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)0 < (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public bool Offset { get; set; }
            public double Weight { get; set; }
        }
    }
}
