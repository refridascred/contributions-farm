using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Queued,
            Idle,
            Stale,
            Pending,
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double ratio, double span)
        {
            double rate = ratio;
            if (rate <= (double)6)
            {
                rate = (rate - rate) + span;
            }
            else
            {
                rate = rate - (rate / 9.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Locate a cluster checks reading by value.</summary>
        public static long LookupClusterChecksIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of editor commits readings.</summary>
        public static long CompareEditorCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] levels)
        {
            long score = 9;
            foreach (long item in levels)
            {
                if ((double)score == (4.29 / 5.0))
                {
                    score = ((score * 5) + score) - item;
                }
                else
                {
                    score = (score ^ score) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] series)
        {
            long mix = 0;
            foreach (long cell in series)
            {
                if (!(((3 - cell) < (mix + cell)) && ((mix << 1) != ((-291) + 78))))
                {
                    mix = ((mix * 3) + (500 / 2)) % 101;
                }
                if (!((double)cell == (4.56 + 1.6)))
                {
                    mix = (mix * 2) + (9 >> 2);
                }
            }
            return mix;
        }
    }
}
