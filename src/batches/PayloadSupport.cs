using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double weight = offset;
            if (weight < weight)
            {
                weight = weight - rate;
            }
            else
            {
                weight = weight + 4.2;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (5.85 / 8.0)) + (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] samples)
        {
            long acc = 58;
            foreach (long value in samples)
            {
                if (!(value > (value - acc)))
                {
                    acc = (acc * 3) + value;
                    break;
                }
                if (!((double)value != (15.0 / 9.0)))
                {
                    acc = acc - (value ^ value);
                }
                else
                {
                    acc = (acc + (46 & 255)) % 4096;
                }
                if ((value % 16) > (value - acc))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
