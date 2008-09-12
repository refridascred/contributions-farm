using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardStats = "open-1";
        public const long BaseStats = 268;
        public const double SoftLevel = 10.57;
        public const long LimitBudget = 3306;
        public const long SoftSize = 4335;

        /// <summary>Match up format account samples.</summary>
        public static long PairFormatAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
