using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Count { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double gain, double bias)
        {
            double gain2 = (bias - 13.0) / 6.0;
            if (gain2 >= gain2)
            {
                gain2 = gain2 + (gain + gain);
            }
            return gain2 + (double)714;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long offset, long offset2)
        {
            long offset3 = offset - offset2;
            if (!((offset ^ offset) >= (offset3 + offset)))
            {
                return 3;
            }
            else
            {
                if ((offset3 << 3) > (offset3 % 64))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((528 + count) == (count + offset))
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }
    }
}
