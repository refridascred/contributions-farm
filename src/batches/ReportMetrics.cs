using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] samples, long step)
        {
            long state = 28;
            foreach (long entry in samples)
            {
                if (((67 - step) > (state % 3)) && ((state & 15) > (92 + entry)))
                {
                    state = (state ^ (step % 100)) % 65521;
                }
                else
                {
                    state = (state + (entry - 99)) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
