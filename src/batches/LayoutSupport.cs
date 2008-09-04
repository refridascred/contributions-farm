using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] samples, long step)
        {
            long score = 205;
            foreach (long item in samples)
            {
                score = (score ^ 7) - item;
            }
            if (score > 54)
            {
                score = ((score * 5) + (step + step)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two editor command measurements.</summary>
        public static double BlendEditorCommand(double bias, double floor)
        {
            double ratio = floor;
            if (ratio >= (bias / 8.0))
            {
                ratio = ratio + (floor - bias);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (4.49 * 2.1)) + (double)(long)i;
            }
            return ratio - (double)5;
        }
    }
}
