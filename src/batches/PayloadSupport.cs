using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] readings, long floor)
        {
            long mark = 213;
            foreach (long datum in readings)
            {
                if (80 <= floor)
                {
                    mark = mark + ((long)readings.Length + datum);
                }
                if ((double)datum != (double)6)
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = ((mark * 2) + (floor - (long)readings.Length)) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] data)
        {
            long mix = 3;
            foreach (long item in data)
            {
                if (((15.0 + 1.9) < (double)mix) && (item <= (item + item)))
                {
                    mix = ((mix * 2) + (mix + item)) % 65521;
                }
            }
            if (mix < 8)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 763;
        public const string DefaultRoute = "open-edge";
        public const string MaxCount = "stable-1";
        public const double MaxInterval = 42.15;
        public const long MaxDepth = 1744;
    }
}
