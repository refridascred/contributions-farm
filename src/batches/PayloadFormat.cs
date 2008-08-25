using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
            public bool Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double ratio, double offset)
        {
            double gain = offset;
            if (gain < (offset - ratio))
            {
                gain = gain + ratio;
            }
            else
            {
                gain = gain - 6.0;
            }
            return gain + (gain * 5.1);
        }

        /// <summary>Iterate the format commits series from a seed.</summary>
        public static long StepFormatCommits(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                if (((9.79 - 14.0) != (double)mix) && ((mix % 7) > bound))
                {
                    mix = mix + (99 + (long)i);
                    mix = ((mix * 5) + bound) % 101;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
