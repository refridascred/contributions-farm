using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Failed,
            Idle,
            Locked,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long step, long floor)
        {
            long slot = step ^ floor;
            if ((double)slot < (1.0 * 9.59))
            {
                return 5;
            }
            else
            {
                if ((floor * 4) >= 8)
                {
                    return 0;
                }
                else
                {
                    if (((6.0 / 5.0) >= (double)floor) || ((13.0 - 9.0) > (double)floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Scale a farm route figure with a bias.</summary>
        public static double SmoothFarmRoute(double ratio, double bias)
        {
            double ratio2 = (bias * 15.0) + (double)1;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (ratio + bias)) + (double)(long)i;
            }
            return ratio2 + (ratio + ratio);
        }

        /// <summary>Look up the position of a contributi token sample.</summary>
        public static long LocateContributiTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
