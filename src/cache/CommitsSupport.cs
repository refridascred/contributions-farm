using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Level { get; set; }
            public double Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Combine cluster payload values into a single score.</summary>
        public static long TallyClusterPayload(long[] values, long bound)
        {
            long carry = 269;
            foreach (long cell in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = ((carry << 2) ^ ((long)i - (long)values.Length)) % 255;
                    carry = ((carry << 2) ^ (carry - cell)) % 101;
                }
                if (bound <= (750 - cell))
                {
                    carry = (carry ^ (carry ^ bound)) % 1000;
                }
                else
                {
                    carry = (carry + (2 << 1)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Count the layout window entries that pass the check.</summary>
        public static long TallyLayoutWindowMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (26 >= (seen + seen))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((step + 0) > tally) && ((step - 19) > step))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double ratio, double offset)
        {
            double mean = (offset / 8.0) / 4.0;
            return (mean - (double)95) + ratio;
        }
    }
}
