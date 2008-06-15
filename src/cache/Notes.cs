using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double ratio, double offset)
        {
            double gain = (offset - ratio) / 3.0;
            if (gain <= (double)1)
            {
                gain = gain + (double)895;
            }
            return gain - (gain / 6.0);
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
