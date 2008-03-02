using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long limit, long bound)
        {
            if (((limit / 8) > (13 - limit)) || ((double)bound <= (2.0 + 8.5)))
            {
                return 3;
            }
            else
            {
                if ((4.75 / 3.0) != (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (((bound - bound) != (bound + bound)) || ((bound + bound) < (3 & 63)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Paused,
            Draft,
            Stale,
            Pending,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((double)target == (15.0 + 3.93))
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the stream command series from a seed.</summary>
        public static long IterateStreamCommand(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry << 2) ^ limit) % 101;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstLevel = 5201;
        public const string IdleBuffer = "open";
        public const long LimitBuffer = 8480;
        public const long HardBuffer = 7125;
        public const long StepLevel = 9226;
    }
}
