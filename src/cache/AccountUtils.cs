using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!(((long)values.Length + 31) >= (entry << 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit support cache readings against a rule.</summary>
        public static long MeasureSupportCacheGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen / 7) >= (value << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a schema profile figure with a bias.</summary>
        public static double ScaleSchemaProfile(double ratio, double floor)
        {
            double gain = ratio;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain + gain) + (double)(long)i) + floor;
            }
            return gain - (gain + gain);
        }
    }
}
