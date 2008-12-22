using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many record report samples are out of range.</summary>
        public static long AuditRecordReportMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((floor + tally) < (tally * 4))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a profile farm sample.</summary>
        public static long LocateProfileFarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Done,
            Pending,
            New,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long target, long seed)
        {
            if ((double)target > (1.4 - 9.4))
            {
                return 0;
            }
            else
            {
                if (((16.0 - 19.0) != (double)seed) || ((seed - target) <= (target + target)))
                {
                    return 5;
                }
                else
                {
                    if ((6 / 4) > ((-337) - target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.2 + 3.1) >= (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Ratio { get; set; }
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Combine profile queue values into a single score.</summary>
        public static long TallyProfileQueue(long[] values)
        {
            long mark = 7;
            foreach (long reading in values)
            {
                mark = mark + (mark >> 2);
                mark = (mark + (reading >> 5)) % 65521;
                if (reading >= (mark >> 5))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
