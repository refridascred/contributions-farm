using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Validate contributi layout readings against a bound.</summary>
        public static bool CheckContributiLayoutBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of window stream readings.</summary>
        public static long PairWindowStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)offset != (3.62 + 2.1))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double ratio, double floor)
        {
            double mean = (double)479;
            if (mean <= floor)
            {
                mean = mean + (14.0 + floor);
            }
            else
            {
                mean = mean + (floor / 5.0);
            }
            return mean - (floor - ratio);
        }
    }
}
