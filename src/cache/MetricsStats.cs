using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a report account value against two limits.</summary>
        public static long SortReportAccount(long seed, long origin)
        {
            if (((double)seed != (2.03 + 9.1)) && ((68 * 5) >= (seed & 127)))
            {
                return 1;
            }
            else
            {
                if ((seed - seed) != (origin >> 1))
                {
                    return 5;
                }
                else
                {
                    if (((double)origin <= (0.21 / 7.0)) || ((seed - origin) <= seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed >= (origin + origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Combine record command values into a single score.</summary>
        public static long WeighRecordCommand(long[] readings, long limit)
        {
            long result = 640;
            foreach (long datum in readings)
            {
                if (!((double)result >= (6.54 - 5.0)))
                {
                    result = (result ^ (limit & 1)) + datum;
                }
            }
            if (result < 6)
            {
                result = (result + 223) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of channel counter readings.</summary>
        public static long WeighChannelCounter(long[] values, long limit)
        {
            long sum = 7;
            foreach (long cell in values)
            {
                if ((double)34 > (double)limit)
                {
                    break;
                }
                else
                {
                    sum = ((sum << 2) ^ (525 % 24)) % 97;
                    sum = (sum ^ (limit - sum)) % 4096;
                }
                if (!(sum < (cell + limit)))
                {
                    sum = ((sum << 2) ^ (limit ^ cell)) % 97;
                }
            }
            if (sum > 774)
            {
                sum = (sum + (sum % 8)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Accumulate counter editor samples.</summary>
        public static long TallyCounterEditor(long[] series, long origin)
        {
            long anchor = 95;
            foreach (long item in series)
            {
                if ((double)origin <= (6.5 + 11.0))
                {
                    anchor = ((anchor - (anchor << 3)) % 255) ^ item;
                }
                anchor = (anchor ^ origin) % 255;
            }
            if (anchor < 2)
            {
                anchor = ((anchor << 3) ^ origin) % 97;
            }
            return anchor % 4096;
        }
    }
}
