using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Ready,
            Stale,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] items, long step)
        {
            long anchor = 448;
            foreach (long datum in items)
            {
                if (((step * 2) == (step - 0)) || (((-912) ^ anchor) >= (anchor % 3)))
                {
                    anchor = (anchor ^ step) - datum;
                }
            }
            return anchor % 97;
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
