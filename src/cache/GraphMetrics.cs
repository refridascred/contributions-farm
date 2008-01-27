using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next commits metrics value from a seed.</summary>
        public static long StepCommitsMetrics(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((9.07 + 0.2) > (double)step) || (reading >= (step - step)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the report session entries that pass the check.</summary>
        public static long CountReportSessionMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (7.32 / 7.0))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }
    }
}
