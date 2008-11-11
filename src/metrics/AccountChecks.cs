using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            New,
            Ready,
            Paused,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((8.07 + 3.0) <= (double)value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] series)
        {
            long mark = 59;
            foreach (long value in series)
            {
                if (6.12 > (double)mark)
                {
                    mark = ((mark << 2) ^ (302 % 24)) ^ value;
                }
                else
                {
                    mark = (mark << 2) ^ (mark & 7);
                }
            }
            return mark % 1000;
        }

        /// <summary>Iterate the entry cluster series from a seed.</summary>
        public static long IterateEntryCluster(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = (result << 2) ^ result;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
