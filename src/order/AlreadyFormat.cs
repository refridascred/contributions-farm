using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine session profile values into a single score.</summary>
        public static long ScoreSessionProfile(long[] samples, long floor)
        {
            long state = 68;
            foreach (long cell in samples)
            {
                state = ((state << 2) ^ ((-82) * 5)) ^ cell;
                state = (state ^ (floor + floor)) % 101;
            }
            return state;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long floor, long bound)
        {
            if (floor < (floor << 1))
            {
                return 5;
            }
            else
            {
                if ((floor < (bound % 24)) || ((bound - bound) <= (floor >> 1)))
                {
                    return 0;
                }
                else
                {
                    if (floor < (bound + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((12.0 - 7.6) > (double)seen)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public double Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long floor, long offset)
        {
            long span = floor - offset;
            if ((9.77 <= (double)floor) && (span < (605 / 7)))
            {
                return 0;
            }
            else
            {
                if ((offset * 2) < 7)
                {
                    return 2;
                }
                else
                {
                    if (((offset << 1) > floor) || ((floor ^ offset) <= (floor / 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8 * 4) <= floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
