using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a command record counter forward.</summary>
        public static long StepCommandRecord(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Active,
            Pending,
            Locked,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)offset < 3.72)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }
    }
}
