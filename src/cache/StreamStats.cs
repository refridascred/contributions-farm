using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a account schema value against two limits.</summary>
        public static long GradeAccountSchema(long origin, long origin2)
        {
            long delta = origin ^ origin2;
            if ((7.9 + 7.0) > (double)origin2)
            {
                return 6;
            }
            else
            {
                if (87 <= origin2)
                {
                    return 4;
                }
                else
                {
                    if ((delta + delta) >= delta)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)640 > (7.0 / 2.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long floor, long step)
        {
            if (((double)floor < 6.0) && ((step + (-703)) < (step & 255)))
            {
                return 4;
            }
            else
            {
                if ((9 % 60) > floor)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
