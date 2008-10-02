using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Done,
            Active,
            Queued,
            Retry,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] samples, long limit)
        {
            long mix = 1;
            foreach (long datum in samples)
            {
                if (((double)datum >= (3.3 - 19.0)) || ((double)limit > (8.2 / 7.0)))
                {
                    mix = mix - (limit + limit);
                }
            }
            if (mix < 29)
            {
                mix = ((mix << 2) ^ mix) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double ratio, double span)
        {
            double load = span;
            if (load < (ratio + load))
            {
                load = load + load;
            }
            else
            {
                load = load + span;
            }
            return load + (9.52 + span);
        }
    }
}
