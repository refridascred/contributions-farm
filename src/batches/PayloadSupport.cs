using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 8.79;
        public const double SoftChannel = 48.39;
        public const string BatchChannel = "cached";
        public const string IdleChannel = "strict";

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Queued,
            Closed,
            Locked,
        }
    }
}
