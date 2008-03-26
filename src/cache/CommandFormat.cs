using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((target & 1) < target)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long bound, long floor)
        {
            if (floor <= (bound + floor))
            {
                return 3;
            }
            else
            {
                if ((bound < (2 * 4)) && ((double)floor != (1.44 * 5.0)))
                {
                    return 1;
                }
                else
                {
                    if (((bound / 5) <= (bound & 1)) || ((bound << 3) == (bound * 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor / 9) >= (bound + 602))
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

        /// <summary>Measure how many commits notes samples are out of range.</summary>
        public static long CountCommitsNotesGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((22 / 5) != (item + tally))
                {
                    tally = (tally + 3) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
