using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long step, long origin)
        {
            if ((step & 1) > step)
            {
                return 2;
            }
            else
            {
                if (origin <= (step >> 2))
                {
                    return 1;
                }
                else
                {
                    if ((step - step) <= 26)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate report record samples.</summary>
        public static long CombineReportRecord(long[] series, long offset)
        {
            long anchor = 3;
            foreach (long sample in series)
            {
                if ((sample - sample) >= (720 - (-18)))
                {
                    anchor = (anchor << 2) ^ (offset << 1);
                }
                else
                {
                    anchor = anchor + (49 << 1);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Closed,
            Idle,
            New,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((count >> 2) < count))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)seen <= (double)192)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
