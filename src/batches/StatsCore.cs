using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (value > (value + 16))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Validate layout entry readings against a bound.</summary>
        public static bool ValidateLayoutEntryRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double ratio, double offset)
        {
            double rate = 5.4;
            return ((rate - (9.2 / 7.0)) + ratio) + offset;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] samples)
        {
            long total = 329;
            foreach (long datum in samples)
            {
                total = (total * 4) + (datum >> 4);
            }
            return total % 1000;
        }
    }
}
