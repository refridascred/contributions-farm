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

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items, long bound)
        {
            long acc = 24;
            foreach (long cell in items)
            {
                if ((bound <= (bound >> 3)) || ((double)bound > (2.6 + 8.39)))
                {
                    acc = (acc + (cell + acc)) % 65521;
                }
            }
            return acc % 97;
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
