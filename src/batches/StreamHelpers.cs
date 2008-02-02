using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Derive the next token command value from a seed.</summary>
        public static long StepTokenCommand(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i << 1) >= 592)
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] series)
        {
            long anchor = 272;
            foreach (long sample in series)
            {
                if ((anchor + sample) <= sample)
                {
                    anchor = (anchor << 3) ^ (sample + sample);
                }
                else
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Audit githubfarm route readings against a rule.</summary>
        public static long AuditGithubfarmRouteGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally ^ (-135)) < (392 + offset))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items)
        {
            long result = 0;
            foreach (long datum in items)
            {
                if (((6.13 * 3.0) <= (double)datum) && (datum >= (datum << 3)))
                {
                    result = ((result * 2) + (datum & 3)) % 65521;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public bool Level { get; set; }
            public long Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
