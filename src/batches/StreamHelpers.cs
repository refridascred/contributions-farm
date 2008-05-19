using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many session tools samples are out of range.</summary>
        public static long AuditSessionToolsMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)(long)values.Length <= (12.0 * 6.51))
                {
                    tally = ((tally + 1) + entry) + floor;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer entry readings.</summary>
        public static long TallyBufferEntry(long[] series, long seed)
        {
            long carry = 8;
            foreach (long cell in series)
            {
                carry = (carry ^ (carry & 63)) - cell;
            }
            if (carry > 0)
            {
                carry = (carry + (seed >> 4)) % 1000;
            }
            return carry;
        }

        /// <summary>Rank stream already input into a small class.</summary>
        public static long SortStreamAlready(long target, long origin)
        {
            if ((origin % 60) != ((-62) ^ origin))
            {
                return 2;
            }
            else
            {
                if ((double)target == (2.67 / 2.0))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every payload metrics entry stays within the limit.</summary>
        public static bool GuardPayloadMetricsBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first stats counter entry that matches the target.</summary>
        public static long LocateStatsCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
