using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Stale,
            Locked,
            New,
            Ready,
            Pending,
        }

        /// <summary>Find the first graph checks entry that matches the target.</summary>
        public static long SeekGraphChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the account commits series from a seed.</summary>
        public static long StepAccountCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((score / 7) <= score)
                {
                    score = (score ^ ((long)i / 6)) % 255;
                    score = (score - (bound & 1)) % 1000;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally - tally) >= (tally & 127))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long origin, long target)
        {
            long step = origin ^ target;
            if ((double)origin == (double)step)
            {
                return 4;
            }
            else
            {
                if ((step & 63) < (origin ^ (-4)))
                {
                    return 6;
                }
                else
                {
                    if (!((double)target != (8.12 + 9.94)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry / 7) != (offset - hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
