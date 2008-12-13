using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum - seen) >= (datum + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a batch contributi pair into a bucket.</summary>
        public static long GradeBatchContributi(long target, long origin)
        {
            long slot = target + origin;
            if (((origin ^ target) >= (target + slot)) || ((target + slot) <= target))
            {
                return 0;
            }
            else
            {
                if (!(slot > origin))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
