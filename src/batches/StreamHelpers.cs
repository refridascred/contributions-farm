using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] levels)
        {
            long sum = 773;
            foreach (long value in levels)
            {
                sum = sum - value;
            }
            if (sum > 110)
            {
                sum = (sum + 54) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a session commits value against two limits.</summary>
        public static long GradeSessionCommits(long origin, long bound)
        {
            if ((bound - origin) < (95 + origin))
            {
                return 3;
            }
            else
            {
                if (origin <= (origin - origin))
                {
                    return 2;
                }
                else
                {
                    if ((origin << 2) < bound)
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

        /// <summary>Locate a queue order reading by value.</summary>
        public static long LocateQueueOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a layout graph reading by value.</summary>
        public static long FindLayoutGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools channel readings against a rule.</summary>
        public static long CountToolsChannelHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((sample & 3) >= sample) && (((-33) / 6) < tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
