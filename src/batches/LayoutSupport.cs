using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(1.0 <= (double)mix))
                {
                    mix = ((mix * 2) + (mix * 5)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
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

        /// <summary>Audit route metric readings against a rule.</summary>
        public static long TallyRouteMetricOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((double)sample > (double)limit) || !((double)sample >= (8.3 + 9.44)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Total { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
