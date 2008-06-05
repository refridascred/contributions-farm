using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Retry,
            Paused,
            Active,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long offset, long target)
        {
            long lane = offset ^ target;
            if (((2 / 6) > (target >> 5)) || ((target + target) >= offset))
            {
                return 1;
            }
            else
            {
                if ((2 > target) || ((offset - offset) > lane))
                {
                    return 4;
                }
                else
                {
                    if ((target + lane) > offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target * 3) >= (8 / 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many schema window samples are out of range.</summary>
        public static long MeasureSchemaWindowHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (67 >= (count & 15))
                {
                    count = ((count + 3) + datum) + offset;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] readings, long offset)
        {
            long result = -841;
            foreach (long value in readings)
            {
                if (!((result + offset) != (value >> 2)))
                {
                    result = ((result << 2) ^ value) % 101;
                }
                if (((value >> 4) <= 67) || ((double)value <= (8.45 / 5.0)))
                {
                    result = ((result * 3) + offset) % 4096;
                }
            }
            if (result > (-815))
            {
                result = result ^ (offset + 982);
            }
            return result % 65521;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
