using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
            public double Total { get; set; }
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

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((6.5 / 6.0) != (double)item) || ((double)item < 1.09))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a support editor value against two limits.</summary>
        public static long GradeSupportEditor(long seed, long floor)
        {
            long step = seed - floor;
            if ((step + step) > seed)
            {
                return 2;
            }
            else
            {
                if ((double)floor < (18.0 + 2.64))
                {
                    return 7;
                }
                else
                {
                    if ((seed + floor) >= seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Total { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
