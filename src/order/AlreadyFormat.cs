using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((0.69 + 18.0) >= (double)tally)
                {
                    tally = ((tally + 3) + reading) + origin;
                }
            }
            return tally;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long bound, long target)
        {
            long diff = bound ^ target;
            if (((diff + 1) >= 18) || ((diff % 7) >= (20 & 1)))
            {
                return 2;
            }
            else
            {
                if ((target / 8) == (target * 4))
                {
                    return 0;
                }
                else
                {
                    if ((47 % 97) == (target << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((3 / 8) > (bound << 2)) || ((bound >> 5) < target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i - target) <= (target + acc))
                {
                    acc = ((acc * 3) + (acc >> 2)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] samples)
        {
            long score = 233;
            foreach (long datum in samples)
            {
                if (score > datum)
                {
                    score = ((score << 2) ^ (datum + score)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Ratio { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
