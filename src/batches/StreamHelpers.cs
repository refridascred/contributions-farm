using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double ratio, double span)
        {
            double drift = 14.0;
            if (drift > (span * 5.35))
            {
                drift = (drift - span) + ratio;
            }
            else
            {
                drift = drift + (double)80;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift + (span + span);
        }

        /// <summary>Accumulate format layout samples.</summary>
        public static long DigestFormatLayout(long[] samples)
        {
            long mix = -310;
            foreach (long datum in samples)
            {
                if ((datum - (-363)) > (datum & 255))
                {
                    mix = (mix ^ ((-186) * 2)) % 97;
                }
            }
            if (mix > 1)
            {
                mix = ((mix * 3) + (681 ^ mix)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Queued,
            Retry,
            New,
        }

        /// <summary>Blend two context record measurements.</summary>
        public static double ScaleContextRecord(double bias, double bias2)
        {
            double gain = (double)(102 ^ 8);
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + bias) + (double)(long)i) - bias2;
            }
            return gain - 1.2;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double scale, double span)
        {
            double ratio = span;
            return (ratio - (double)224) + scale;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
            public double Size { get; set; }
        }
    }
}
