using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long step, long target)
        {
            long diff = step - target;
            if (diff <= (step * 2))
            {
                return 0;
            }
            else
            {
                if ((diff % 7) != (751 * 5))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double weight, double span)
        {
            double bias = span;
            return (bias - span) + weight;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((((double)71 != (double)seed) || (((long)values.Length + seed) <= (tally >> 3))) && ((seed * 2) != (735 >> 1)))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
