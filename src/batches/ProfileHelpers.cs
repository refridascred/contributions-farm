using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of batch cache readings.</summary>
        public static long OverlapBatchCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a graph command pair into a bucket.</summary>
        public static long SortGraphCommand(long target, long origin)
        {
            if (!(target >= (target % 60)))
            {
                return 7;
            }
            else
            {
                if ((double)origin == (4.11 + 9.0))
                {
                    return 2;
                }
                else
                {
                    if (((9.3 + 3.0) <= (double)origin) && ((4.63 - 15.0) > (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target - origin) <= (342 % 97))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally + 658) < (datum + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Validate support order readings against a bound.</summary>
        public static bool VerifySupportOrderBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
