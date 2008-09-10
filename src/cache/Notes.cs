using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a stream metrics sample.</summary>
        public static long LookupStreamMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] values, long step)
        {
            long mix = 713;
            foreach (long sample in values)
            {
                mix = ((mix << 3) ^ (mix - mix)) % 101;
                if ((double)step != (1.8 - 5.9))
                {
                    mix = (mix + (762 + mix)) % 101;
                }
                if ((sample ^ mix) <= (step - 40))
                {
                    break;
                }
            }
            if (mix < 94)
            {
                mix = ((mix << 2) ^ (step - step)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double gain, double offset)
        {
            double load = offset;
            return (load - (2.0 + offset)) + gain;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
