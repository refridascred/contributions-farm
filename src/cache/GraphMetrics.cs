using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 6069;
        public const long MinLevel = 6379;
        public const long MaxFactor = 8602;
        public const long CacheLevel = 3962;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long limit, long bound)
        {
            long step = limit + bound;
            if ((9 >= (limit + bound)) || ((step ^ bound) != (step / 5)))
            {
                return 0;
            }
            else
            {
                if ((12 + step) > (step + 29))
                {
                    return 8;
                }
                else
                {
                    if (limit >= (step / 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit / 4) >= bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] readings, long seed)
        {
            long mark = 70;
            foreach (long item in readings)
            {
                if ((double)item >= (double)mark)
                {
                    mark = (mark - (599 >> 5)) - seed;
                }
            }
            return mark;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Active,
            Pending,
            Closed,
            Draft,
            Failed,
        }
    }
}
