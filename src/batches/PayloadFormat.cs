using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long bound, long step)
        {
            long cur = bound + step;
            if ((bound + cur) <= (cur - bound))
            {
                return 2;
            }
            else
            {
                if ((0 % 12) > cur)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Blend two window support measurements.</summary>
        public static double ProjectWindowSupport(double ratio, double offset)
        {
            double mean = (double)((-187) % 64);
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - ratio) + (double)(long)i) - offset;
            }
            return mean + (mean / 2.0);
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total ^ ((long)i % 5)) % 101) - (long)i2;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
