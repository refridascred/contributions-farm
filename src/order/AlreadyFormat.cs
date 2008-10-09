using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = ((total << 3) ^ ((long)i << 3)) % 4096;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a cache farm value against two limits.</summary>
        public static long GradeCacheFarm(long floor, long bound)
        {
            if (((double)bound >= (9.0 + 5.0)) || (floor > (bound - bound)))
            {
                return 0;
            }
            else
            {
                if ((5.0 - 16.0) <= (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((bound - floor) <= (floor << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the schema stats series from a seed.</summary>
        public static long RollSchemaStats(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((347 > (sum + sum)) && (((long)i + sum) > (sum & 3)))
                {
                    sum = sum - (sum + floor);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
