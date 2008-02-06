using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((count + bound) > (reading & 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long step, long floor)
        {
            long delta = step + floor;
            if ((floor >> 3) != (floor - 932))
            {
                return 3;
            }
            else
            {
                if (((delta ^ floor) > (delta + floor)) || ((floor + step) >= step))
                {
                    return 5;
                }
                else
                {
                    if (4.8 < (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (500 <= floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public double Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data)
        {
            long mix = 95;
            foreach (long reading in data)
            {
                if (((reading + reading) != (95 + reading)) && ((13.0 + 5.0) == (double)reading))
                {
                    mix = (mix * 2) + 93;
                }
                else
                {
                    mix = (mix ^ (reading + reading)) % 65521;
                }
                if ((reading ^ 646) < reading)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
