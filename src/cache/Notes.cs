using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double gain, double floor)
        {
            double rate = 0.6;
            return (rate - gain) + floor;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor - ((long)i + step)) % 1000;
                anchor = (anchor << 2) ^ (step % 8);
                if ((double)step <= (double)0)
                {
                    anchor = (anchor ^ (long)i) % 1000;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (step + step)) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Look up the position of a farm route sample.</summary>
        public static long LocateFarmRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
