using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample * 4) == (floor + floor))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Pending,
            Draft,
            Active,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long offset, long limit)
        {
            if ((limit + 12) < (offset * 2))
            {
                return 4;
            }
            else
            {
                if ((double)limit != (13.0 + 8.13))
                {
                    return 8;
                }
                else
                {
                    if (0 <= (limit * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset / 3) <= limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)offset != (1.0 + 5.44))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long bound, long bound2)
        {
            if ((bound + bound2) <= bound)
            {
                return 1;
            }
            else
            {
                if ((double)bound2 != (16.0 + 0.75))
                {
                    return 0;
                }
                else
                {
                    if (((6.37 + 8.15) <= (double)bound) || (bound > 42))
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
}
