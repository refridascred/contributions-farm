using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double bias)
        {
            double mean = bias / 5.0;
            if (mean >= (mean / 2.0))
            {
                mean = mean + (mean * 6.0);
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + scale) + (double)(long)i;
            }
            return mean + (double)354;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Failed,
            Done,
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a channel report counter forward.</summary>
        public static long DeriveChannelReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] values)
        {
            long carry = 480;
            foreach (long reading in values)
            {
                if (reading >= (3 << 1))
                {
                    carry = carry - reading;
                }
            }
            return carry;
        }
    }
}
