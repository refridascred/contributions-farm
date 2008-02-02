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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value >= (value + value))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long seed, long target)
        {
            if (!((target ^ seed) <= target))
            {
                return 0;
            }
            else
            {
                if (((target + target) < seed) || ((seed & 7) <= 2))
                {
                    return 8;
                }
                else
                {
                    if (!((target - seed) == (target + seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
