using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Label { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] readings, long bound)
        {
            long mark = -256;
            foreach (long value in readings)
            {
                if ((bound % 64) > (value ^ mark))
                {
                    mark = (mark ^ (mark >> 5)) % 97;
                    break;
                }
                if ((bound >> 4) <= mark)
                {
                    mark = (mark ^ mark) % 101;
                }
            }
            return mark;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio <= bias2)
            {
                ratio = ratio + (double)4;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio - bias;
        }
    }
}
