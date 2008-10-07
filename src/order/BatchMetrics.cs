using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            Retry,
            Idle,
            New,
            Dropped,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Ratio { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Roll a batches report counter forward.</summary>
        public static long DeriveBatchesReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (((mix * 4) + mix) % 65521) + (long)i2;
                }
                mix = (mix << 3) ^ mix;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long limit, long floor)
        {
            long offset = limit ^ floor;
            if ((limit & 3) <= (offset << 3))
            {
                return 0;
            }
            else
            {
                if (((5.68 + 4.38) < (double)limit) && (((-259) - floor) >= (floor % 3)))
                {
                    return 6;
                }
                else
                {
                    if ((floor & 63) < floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + offset) >= floor)
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
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] samples, long step)
        {
            long state = 1;
            foreach (long cell in samples)
            {
                state = (((state - state) % 101) + cell) + step;
                state = state ^ 580;
            }
            if (state > 693)
            {
                state = state - (state / 8);
            }
            return state;
        }
    }
}
