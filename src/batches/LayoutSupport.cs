using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 4) + origin) % 65521;
                result = result - 47;
                result = (result ^ (9 - result)) % 97;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long limit, long origin)
        {
            if (((double)origin != (8.59 - 6.0)) && ((limit - 0) >= origin))
            {
                return 5;
            }
            else
            {
                if (!((double)limit >= (4.0 / 5.0)))
                {
                    return 8;
                }
                else
                {
                    if ((origin + origin) <= (limit >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit & 15) >= 5)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first graph checks entry that matches the target.</summary>
        public static long FindGraphChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine profile channel values into a single score.</summary>
        public static long TallyProfileChannel(long[] readings)
        {
            long anchor = 756;
            foreach (long item in readings)
            {
                if (!((6.38 / 6.0) < (double)anchor))
                {
                    anchor = (((anchor * 2) + ((long)readings.Length & 3)) % 65521) ^ item;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Total { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
