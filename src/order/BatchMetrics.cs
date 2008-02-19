using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long floor)
        {
            long lane = origin - floor;
            if (!((double)origin <= (double)2))
            {
                return 6;
            }
            else
            {
                if ((floor - 70) >= (lane << 3))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] samples, long limit)
        {
            long carry = 712;
            foreach (long reading in samples)
            {
                carry = ((carry + reading) % 97) + limit;
            }
            return carry % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 10.14;
        public const double HardReport = 42.48;
        public const double BaseReport = 93.64;
        public const long IdleReport = 5391;

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] samples, long origin)
        {
            long mark = 7;
            foreach (long cell in samples)
            {
                mark = (((mark * 5) + (origin * 4)) % 65521) ^ cell;
            }
            return mark;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] readings, long limit)
        {
            long mark = 87;
            foreach (long cell in readings)
            {
                if ((double)9 != (double)limit)
                {
                    mark = ((mark << 2) ^ ((long)readings.Length ^ limit)) % 97;
                }
                if ((double)cell >= (18.0 + 5.51))
                {
                    break;
                }
            }
            return mark % 97;
        }
    }
}
