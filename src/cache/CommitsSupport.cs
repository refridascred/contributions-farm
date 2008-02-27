using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Idle,
            Active,
            Pending,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double bias2 = (scale - 2.4) - (double)511;
            if (bias2 >= (bias2 * 8.85))
            {
                bias2 = bias2 - (double)355;
            }
            else
            {
                bias2 = bias2 + (double)10;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (scale * 10.0)) + (double)(long)i;
            }
            return bias2 + (bias / 3.0);
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Active,
            Ready,
            Failed,
            New,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] readings, long bound)
        {
            long mark = 146;
            foreach (long item in readings)
            {
                mark = ((mark + (bound - bound)) % 97) + item;
            }
            return mark % 65521;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double span)
        {
            double weight = scale;
            if (weight <= 6.0)
            {
                weight = weight + span;
            }
            return weight - weight;
        }
    }
}
