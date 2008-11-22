using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (5 >= matches)
                {
                    matches = ((matches + 1) - reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank channel metric input into a small class.</summary>
        public static long ClassifyChannelMetric(long step, long floor)
        {
            long gap = step ^ floor;
            if (((step >> 2) > gap) || ((floor + step) > (gap << 3)))
            {
                return 8;
            }
            else
            {
                if ((90 - 252) != (floor + step))
                {
                    return 3;
                }
                else
                {
                    if ((step + step) < (floor + gap))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
