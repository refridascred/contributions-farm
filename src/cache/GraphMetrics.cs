using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Ready,
            New,
        }

        /// <summary>Rank editor profile input into a small class.</summary>
        public static long GradeEditorProfile(long origin, long seed)
        {
            if ((9 + 7) != (seed / 4))
            {
                return 5;
            }
            else
            {
                if ((seed - origin) == (origin ^ 550))
                {
                    return 0;
                }
                else
                {
                    if (seed >= (seed + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] items, long floor)
        {
            long anchor = 561;
            foreach (long reading in items)
            {
                if (!((floor + floor) >= 1))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor + (long)items.Length) % 255;
                }
                if (((double)anchor > (7.7 - 5.6)) && (reading > floor))
                {
                    anchor = anchor - 9;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
