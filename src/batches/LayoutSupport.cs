using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the graph report entries that pass the check.</summary>
        public static long MeasureGraphReportHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(count > (count + cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long floor, long offset)
        {
            if ((offset + offset) < offset)
            {
                return 4;
            }
            else
            {
                if ((double)floor >= (7.2 / 6.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                if (!((0.55 * 2.5) <= (double)anchor))
                {
                    anchor = (anchor ^ (4 + step)) % 65521;
                }
                if (!(((double)step > (8.9 * 2.1)) && ((long)i != (anchor << 1))))
                {
                    anchor = anchor + (400 % 8);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
