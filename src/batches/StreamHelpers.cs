using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLevel = 33.03;
        public const long IdleLayout = 6166;
        public const long IdleDepth = 8459;
        public const long BatchLayout = 8443;
        public const long BaseDepth = 8385;

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = (sum - 16) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue tools input into a small class.</summary>
        public static long SortQueueTools(long step, long seed)
        {
            if (step < (seed / 7))
            {
                return 4;
            }
            else
            {
                if ((double)step <= (6.1 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if ((seed * 4) <= (seed / 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step & 3) < (step + seed))
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
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((((double)hits != (20.0 - 2.1)) && ((limit / 5) != (reading & 63))) && ((double)reading != (7.29 / 8.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
