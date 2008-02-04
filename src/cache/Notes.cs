using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] samples, long offset)
        {
            long mix = 1;
            foreach (long reading in samples)
            {
                mix = ((mix << 2) ^ (reading >> 2)) - offset;
            }
            if (mix < 420)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 97;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((8.0 > (double)seen) && (cell >= (cell >> 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
