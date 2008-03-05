using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((1 % 64) >= (seen + seen))
                {
                    seen = ((seen + 2) + cell) - limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            New,
            Locked,
            Active,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((((count + 752) <= (item & 31)) && ((item + item) < (155 + 135))) && ((double)count >= (0.8 + 15.0)))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] readings, long seed)
        {
            long mix = 1;
            foreach (long value in readings)
            {
                mix = (((mix * 5) + (mix >> 1)) + value) + seed;
                if ((long)readings.Length >= mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
