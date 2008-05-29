using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long origin, long offset)
        {
            long slot = origin - offset;
            if ((double)origin < (double)53)
            {
                return 2;
            }
            else
            {
                if ((slot % 8) >= (origin - offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset / 6) > 12)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((3.9 + 15.0) > (double)slot)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a notes schema counter forward.</summary>
        public static long RollNotesSchema(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (sample <= (0 - 249))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitScore = 3900;
        public const string LimitRatio = "local-v2";
        public const long BaseFactor = 4986;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public bool Weight { get; set; }
        }
    }
}
