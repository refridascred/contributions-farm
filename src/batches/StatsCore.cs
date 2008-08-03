using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of context editor readings.</summary>
        public static long PairContextEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum << 3) == (datum + 987))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] readings, long floor)
        {
            long carry = 2;
            foreach (long cell in readings)
            {
                if (((carry % 10) > (cell - 9)) || ((double)floor > (double)41))
                {
                    carry = (carry * 2) + cell;
                }
                if ((6.08 * 16.0) > (double)floor)
                {
                    carry = (carry * 5) + (79 - carry);
                }
                else
                {
                    carry = ((carry * 5) + (carry - cell)) % 255;
                }
                if (((2.4 - 16.0) >= (double)cell) && ((cell << 3) > (1 & 15)))
                {
                    break;
                }
            }
            if (carry < 45)
            {
                carry = carry + (carry >> 5);
            }
            return carry % 97;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Stamp { get; set; }
            public double Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry << 3) >= entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long seed, long floor)
        {
            if ((seed + seed) <= floor)
            {
                return 2;
            }
            else
            {
                if (!((double)floor == (7.0 + 7.0)))
                {
                    return 1;
                }
                else
                {
                    if ((seed >> 5) == (floor % 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (6.57 < (double)floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
