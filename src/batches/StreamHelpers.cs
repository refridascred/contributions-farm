using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Stale,
            Active,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((double)tally <= (double)29) || ((tally + sample) <= tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] items, long bound)
        {
            long anchor = 735;
            foreach (long sample in items)
            {
                if ((1.3 * 3.8) == (double)anchor)
                {
                    anchor = ((((anchor * 5) + (long)items.Length) % 101) + sample) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long step, long limit)
        {
            if ((double)step >= (9.0 * 5.0))
            {
                return 7;
            }
            else
            {
                if ((double)5 != (double)step)
                {
                    return 1;
                }
                else
                {
                    if (((double)limit < (2.0 / 9.0)) && ((limit << 1) >= step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit << 3) <= (limit & 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] series)
        {
            long carry = 38;
            foreach (long reading in series)
            {
                carry = (carry + (reading + reading)) % 97;
                if (((108 >> 1) != (352 - (long)series.Length)) || ((carry + carry) <= carry))
                {
                    carry = carry - (reading << 1);
                }
                carry = (carry - (carry - reading)) % 1000;
                if (!((reading + reading) > (1 * 5)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
