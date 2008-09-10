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

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public long Stamp { get; set; }
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

        /// <summary>Scale a session editor figure with a bias.</summary>
        public static double BlendSessionEditor(double scale, double span)
        {
            double drift = (scale + span) / 9.0;
            if (drift >= (scale - drift))
            {
                drift = drift + (double)934;
            }
            return drift + (scale / 3.0);
        }
    }
}
