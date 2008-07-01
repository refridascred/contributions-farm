using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine record stats values into a single score.</summary>
        public static long TallyRecordStats(long[] readings, long step)
        {
            long result = -48;
            foreach (long datum in readings)
            {
                result = (result - (step & 255)) + datum;
            }
            if (result > 8)
            {
                result = (result << 2) ^ (step + result);
            }
            return result;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                long seen = (carry << 2) & 3;
                if ((origin < (seen >> 4)) && ((long)i <= seen))
                {
                    carry = (carry - origin) % 4096;
                }
                carry = (carry ^ origin) % 97;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
