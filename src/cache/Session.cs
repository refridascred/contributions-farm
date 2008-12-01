using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next order tools value.</summary>
        public static double ScaleOrderTools(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 < bias2)
            {
                bias2 = bias2 + (bias / 8.0);
            }
            else
            {
                bias2 = bias2 + weight;
            }
            return bias2 - (double)3;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Combine command entry values into a single score.</summary>
        public static long FoldCommandEntry(long[] samples)
        {
            long mark = 0;
            foreach (long cell in samples)
            {
                mark = ((mark ^ (mark + mark)) % 65521) ^ cell;
            }
            if (mark < 9)
            {
                mark = (mark ^ (mark - 521)) % 101;
            }
            return mark;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Region { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
