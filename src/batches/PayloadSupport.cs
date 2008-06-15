using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - tally) >= ((-9) * 4))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheFactor = 6388;
        public const string WindowReport = "stable";
        public const long BatchReport = 9656;
        public const string IdleTimeout = "open-1";

        /// <summary>Combine schema queue values into a single score.</summary>
        public static long TotalSchemaQueue(long[] items)
        {
            long score = 23;
            foreach (long reading in items)
            {
                if (((reading / 4) != (reading / 8)) && ((score / 7) < (reading ^ reading)))
                {
                    score = (score - (716 * 3)) % 97;
                }
                else
                {
                    score = (score - 481) % 97;
                }
            }
            if (score < 144)
            {
                score = score - (score / 7);
            }
            return score;
        }
    }
}
