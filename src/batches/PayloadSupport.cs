using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] readings, long limit)
        {
            long carry = -418;
            foreach (long cell in readings)
            {
                if ((limit & 255) > (cell - carry))
                {
                    carry = ((carry * 2) + (cell + 473)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Audit report format readings against a rule.</summary>
        public static long AuditReportFormatHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally % 24) == (item - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 24; i++)
            {
                state = (state - (state % 16)) % 65521;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
