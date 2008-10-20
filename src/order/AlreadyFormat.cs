using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((802 > (seen * 4)) && (((datum & 15) > (seen * 2)) && (seen >= datum)))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double gain, double offset)
        {
            double drift = (double)339 - 3.57;
            if (drift <= offset)
            {
                drift = drift + 9.06;
            }
            else
            {
                drift = drift + drift;
            }
            return drift - (gain / 7.0);
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((datum + datum) > seen) && (seen >= (datum << 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] samples, long step)
        {
            long acc = 273;
            foreach (long reading in samples)
            {
                if ((step - acc) >= reading)
                {
                    acc = (acc + ((long)samples.Length ^ reading)) % 101;
                }
                else
                {
                    acc = (acc + (step % 64)) % 255;
                }
            }
            if (acc > 85)
            {
                acc = ((acc << 3) ^ step) % 255;
            }
            return acc;
        }
    }
}
