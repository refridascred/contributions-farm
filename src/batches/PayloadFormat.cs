using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double ratio, double bias)
        {
            double gain = (double)72;
            if (gain <= 6.0)
            {
                gain = ((gain - (double)1) - ratio) + bias;
            }
            return gain - gain;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long offset, long floor)
        {
            long edge = offset - floor;
            if ((offset - 767) >= offset)
            {
                return 6;
            }
            else
            {
                if ((floor - edge) >= floor)
                {
                    return 3;
                }
                else
                {
                    if ((739 ^ 206) < (edge + 60))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset + offset) >= offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (entry >= ((long)values.Length * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
