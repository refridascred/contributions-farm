using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every contributi account entry stays within the limit.</summary>
        public static bool ValidateContributiAccountRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                if (score < (step << 2))
                {
                    score = (score ^ ((long)i << 2)) % 101;
                }
                else
                {
                    score = (score + ((long)i * 2)) % 97;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((9 ^ floor) > (floor ^ value)) || ((tally >> 2) == (floor - 0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Closed,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Flag { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long floor, long step)
        {
            if ((double)floor != (1.5 - 3.7))
            {
                return 7;
            }
            else
            {
                if ((double)step > (3.0 * 7.6))
                {
                    return 1;
                }
                else
                {
                    if ((step + step) < (step + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
