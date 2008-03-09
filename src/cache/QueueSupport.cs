using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Look up the position of a profile metrics sample.</summary>
        public static long FindProfileMetricsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)origin == (5.4 + 0.7))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }
    }
}
