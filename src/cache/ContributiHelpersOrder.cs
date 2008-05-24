using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                mark = mark + (target - (-72));
                if (target <= mark)
                {
                    mark = (mark * 5) + ((long)i % 8);
                }
                else
                {
                    mark = (mark << 2) ^ ((long)i ^ mark);
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
