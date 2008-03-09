using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate counter contributi readings against a bound.</summary>
        public static bool ValidateCounterContributiLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((19.0 >= (double)entry) || ((double)(long)levels.Length > 9.0))
                {
                    tally = (tally + 2) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Level { get; set; }
            public double Size { get; set; }
        }
    }
}
