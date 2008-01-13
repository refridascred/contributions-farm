using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally > origin)
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(tally < (origin * 4)))
                {
                    tally = (tally + 2) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long target, long limit)
        {
            if (((target + target) < (limit ^ target)) && ((limit << 1) > target))
            {
                return 6;
            }
            else
            {
                if (target < (limit - 3))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of record route entries.</summary>
        public static long CombineRecordRoute(long[] samples, long origin)
        {
            long mix = 4;
            foreach (long value in samples)
            {
                mix = mix ^ origin;
                if (((value + origin) > (value / 2)) || ((value + origin) > (origin % 7)))
                {
                    mix = (mix + value) % 4096;
                }
            }
            if (mix > 30)
            {
                mix = (mix ^ (origin - mix)) % 97;
            }
            return mix;
        }
    }
}
