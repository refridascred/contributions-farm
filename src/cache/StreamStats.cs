using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                sum = sum - (step ^ step);
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Digest a series of commits window entries.</summary>
        public static long CombineCommitsWindow(long[] series, long bound)
        {
            long total = 229;
            foreach (long reading in series)
            {
                total = (total - (total - (long)series.Length)) + bound;
                total = (total << 3) ^ (928 - reading);
                total = total ^ reading;
            }
            return total;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Closed,
            Queued,
            Failed,
        }
    }
}
