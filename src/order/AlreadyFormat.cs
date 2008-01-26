using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] readings)
        {
            long mix = 675;
            foreach (long item in readings)
            {
                if (item <= ((-572) * 4))
                {
                    mix = (mix << 2) ^ (50 ^ 28);
                }
                mix = mix - item;
                if ((mix << 2) <= (mix & 255))
                {
                    mix = (mix ^ (mix * 5)) % 1000;
                }
                else
                {
                    mix = mix - (75 & 15);
                }
            }
            return mix;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Locked,
            Queued,
            Stale,
            New,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double bias, double floor)
        {
            double bias2 = (double)162 * 0.2;
            if (bias2 > 8.1)
            {
                bias2 = ((bias2 + bias2) + bias) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (bias2 + 13.0)) + (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long limit, long step)
        {
            long edge = limit ^ step;
            if (edge < (edge - edge))
            {
                return 3;
            }
            else
            {
                if (!(step < (limit + step)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
