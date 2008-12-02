using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit support stream readings against a rule.</summary>
        public static long AuditSupportStreamHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((seen >> 5) > sample))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Classify a checks stats pair into a bucket.</summary>
        public static long GradeChecksStats(long floor, long seed)
        {
            long edge = floor - seed;
            if (!(edge < seed))
            {
                return 8;
            }
            else
            {
                if ((seed > (floor & 15)) || ((4.7 / 7.0) != (double)edge))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
