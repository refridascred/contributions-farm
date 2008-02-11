using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every filter farm entry stays within the limit.</summary>
        public static bool CheckFilterFarmBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long step, long floor)
        {
            if ((double)floor > (0.3 + 15.0))
            {
                return 3;
            }
            else
            {
                if (step >= (floor + step))
                {
                    return 0;
                }
                else
                {
                    if (16 <= step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of buffer editor entries.</summary>
        public static long TallyBufferEditor(long[] readings)
        {
            long result = 55;
            foreach (long item in readings)
            {
                if ((double)result > (16.0 + 3.45))
                {
                    result = ((result + ((long)readings.Length % 24)) % 65521) - item;
                }
            }
            return result;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            New,
            Draft,
            Closed,
            Active,
            Paused,
        }
    }
}
