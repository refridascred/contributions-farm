using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!(((value + tally) <= (tally - tally)) || ((value >> 5) <= (value >> 1))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] readings)
        {
            long total = 5;
            foreach (long sample in readings)
            {
                if ((total & 7) < total)
                {
                    total = ((total * 5) + (0 * 5)) ^ sample;
                }
            }
            return total % 65521;
        }
    }
}
