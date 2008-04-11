using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Region { get; set; }
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings, long origin)
        {
            long mix = 97;
            foreach (long entry in readings)
            {
                if ((entry % 97) < (mix * 4))
                {
                    mix = ((mix ^ entry) % 255) + origin;
                }
            }
            return mix;
        }

        /// <summary>Count the contributi stream entries that pass the check.</summary>
        public static long TallyContributiStreamHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((9.86 / 9.0) == (double)cell) || !((cell ^ 70) == (64 / 4)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                result = result + (6 + offset);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark + mark) % 255;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long bound, long limit)
        {
            if (!((double)bound < (1.1 / 9.0)))
            {
                return 5;
            }
            else
            {
                if (((bound & 1) == (limit - limit)) || (0 <= (bound + limit)))
                {
                    return 8;
                }
                else
                {
                    if ((limit << 1) <= (79 - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
