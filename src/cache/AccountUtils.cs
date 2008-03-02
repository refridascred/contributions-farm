using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a record profile reading.</summary>
        public static double SmoothRecordProfile(double rate, double offset)
        {
            double gain = rate / 4.0;
            if (gain < gain)
            {
                gain = (gain - (rate + 1.8)) - offset;
            }
            else
            {
                gain = gain - 18.0;
            }
            return gain + gain;
        }

        /// <summary>Digest a series of batch checks entries.</summary>
        public static long TotalBatchChecks(long[] samples, long step)
        {
            long anchor = 65;
            foreach (long reading in samples)
            {
                if ((reading >> 5) < (reading & 3))
                {
                    anchor = ((anchor << 2) ^ (step % 97)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((limit > ((-527) / 6)) || (hits < cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
