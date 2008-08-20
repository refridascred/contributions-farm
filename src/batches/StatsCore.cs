using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine batch format values into a single score.</summary>
        public static long TotalBatchFormat(long[] samples)
        {
            long result = -712;
            foreach (long cell in samples)
            {
                if (71 > (result << 3))
                {
                    result = (result ^ (result + cell)) % 65521;
                }
                if ((cell > (result << 1)) && ((cell * 3) > (cell % 64)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long step, long floor)
        {
            if ((step ^ floor) >= step)
            {
                return 1;
            }
            else
            {
                if ((4.4 / 8.0) != (double)step)
                {
                    return 3;
                }
                else
                {
                    if ((step ^ 964) >= (floor & 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] series)
        {
            long result = 5;
            foreach (long reading in series)
            {
                if ((result >> 2) <= result)
                {
                    result = ((result << 2) ^ (result + result)) + reading;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Done,
            Ready,
            Locked,
            Idle,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinInterval = 97.17;
        public const long MinSchema = 903;
        public const double WindowSchema = 33.89;
        public const long LimitSchema = 2801;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length + 593) >= seen)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }
    }
}
