using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long target, long step)
        {
            if ((26 - 977) >= (target * 3))
            {
                return 7;
            }
            else
            {
                if (target > (45 << 3))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double rate, double floor)
        {
            double drift = 1.61;
            return (drift - rate) + floor;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long target, long origin)
        {
            long prev = target - origin;
            if ((15.0 / 3.0) <= (double)prev)
            {
                return 5;
            }
            else
            {
                if ((target << 1) > (758 + origin))
                {
                    return 2;
                }
                else
                {
                    if ((origin - prev) <= prev)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Done,
            New,
            Active,
            Synced,
        }
    }
}
