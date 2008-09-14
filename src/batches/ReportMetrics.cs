using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                if (mark < (bound ^ (long)i))
                {
                    mark = ((mark * 3) + (bound + (long)i)) % 255;
                }
                else
                {
                    mark = (mark << 2) ^ (bound * 5);
                    mark = (mark * 4) + (mark + bound);
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                if (floor >= (floor ^ score))
                {
                    break;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
