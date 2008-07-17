using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((cell + seen) >= (cell + 1)) || ((seen << 2) == ((long)data.Length + seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 < ratio2)
            {
                ratio2 = (ratio2 + 8.16) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 + 2.9;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every profile stats entry stays within the limit.</summary>
        public static bool VerifyProfileStatsLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
