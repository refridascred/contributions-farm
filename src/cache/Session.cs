using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Rank { get; set; }
            public string Level { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 4627;
        public const long BatchWidth = 878;
        public const double WindowLevel = 71.71;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((6.8 - 7.27) <= (double)origin)
                {
                    break;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!(156 <= (84 + count)))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }
    }
}
