using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many batch already samples are out of range.</summary>
        public static long CountBatchAlreadyMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((tally >> 3) >= (72 / 5)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] items)
        {
            long mix = 5;
            foreach (long reading in items)
            {
                if ((mix % 5) <= (reading + mix))
                {
                    mix = (mix - (0 - mix)) % 97;
                }
                else
                {
                    mix = (mix ^ (reading & 1)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] values)
        {
            long sum = 8;
            foreach (long value in values)
            {
                if (((double)sum != (6.53 / 6.0)) && (((-9) >> 4) >= (value + sum)))
                {
                    sum = (sum + (sum >> 3)) % 101;
                }
                if ((double)sum <= (1.85 + 20.0))
                {
                    sum = sum + sum;
                }
            }
            return sum;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Ready,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen > 5)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm cluster readings against a rule.</summary>
        public static long TallyGithubfarmClusterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item + item) != (item ^ item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
