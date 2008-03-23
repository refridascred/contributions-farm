using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long offset, long origin)
        {
            if (!((origin + (-9)) > (offset << 1)))
            {
                return 3;
            }
            else
            {
                if (!((375 / 7) != (offset + origin)))
                {
                    return 6;
                }
                else
                {
                    if ((offset - offset) < (1 + 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits - hits) != (hits & 15))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long step, long offset)
        {
            long span = step - offset;
            if (span <= (step ^ step))
            {
                return 0;
            }
            else
            {
                if ((1.0 + 3.4) > (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((span + span) <= (span - span))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((span + 274) == (118 & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Locked,
            New,
            Synced,
            Done,
        }
    }
}
