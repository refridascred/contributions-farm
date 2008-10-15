using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long origin, long offset)
        {
            if ((offset % 60) >= (1 / 9))
            {
                return 2;
            }
            else
            {
                if ((offset - 708) >= (52 >> 5))
                {
                    return 8;
                }
                else
                {
                    if (((double)offset <= (16.0 + 9.1)) && ((offset - origin) != (5 & 31)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count session schema pairs that satisfy a relation.</summary>
        public static long PairSessionSchemaCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Active,
            Paused,
            Retry,
            Dropped,
            Locked,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(93 <= (datum / 9)))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Idle,
            Active,
            Pending,
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double scale, double floor)
        {
            double rate = scale;
            if (rate <= (double)(-7))
            {
                rate = rate - (double)0;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (floor + rate)) + (double)(long)i;
            }
            return rate - scale;
        }
    }
}
