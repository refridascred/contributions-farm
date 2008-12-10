using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate record buffer readings against a bound.</summary>
        public static bool GuardRecordBufferLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)cell > (5.7 * 0.6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Label { get; set; }
            public string Level { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
