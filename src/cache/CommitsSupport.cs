using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((origin & 127) <= (datum + origin))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            Active,
            Stale,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long limit, long limit2)
        {
            if (!(limit <= (limit2 - limit2)))
            {
                return 5;
            }
            else
            {
                if ((94 + limit) > 58)
                {
                    return 4;
                }
                else
                {
                    if ((5.53 >= (double)limit2) || ((double)limit2 >= (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit2 - limit2) > (limit / 3)) || (limit < (limit + limit2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double bias, double span)
        {
            double load = bias;
            if (load >= (span * 8.0))
            {
                load = load - (8.5 / 9.0);
            }
            else
            {
                load = load - (bias - 0.3);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + span;
        }
    }
}
