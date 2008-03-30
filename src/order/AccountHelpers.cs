using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the notes command entries that pass the check.</summary>
        public static long CountNotesCommandMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading <= (count - reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long offset, long step)
        {
            long diff = offset + step;
            if (!((diff >> 3) <= diff))
            {
                return 3;
            }
            else
            {
                if ((double)diff != (15.0 - 17.0))
                {
                    return 0;
                }
                else
                {
                    if (offset > (580 * 5))
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftBudget = 3285;
        public const string IdleInterval = "staging-1";
        public const double HardContributi = 87.04;
        public const long MinContributi = 8249;
        public const string SoftContributi = "standard-1";

        /// <summary>Audit cluster account readings against a rule.</summary>
        public static long MeasureClusterAccountMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!(step > sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank notes session input into a small class.</summary>
        public static long GradeNotesSession(long limit, long origin)
        {
            long span = limit - origin;
            if (((917 % 5) <= (799 + limit)) && ((span % 5) <= (limit - span)))
            {
                return 1;
            }
            else
            {
                if ((origin * 2) < origin)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
