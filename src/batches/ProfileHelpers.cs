using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] series, long seed)
        {
            long mark = 99;
            foreach (long sample in series)
            {
                if ((sample + seed) >= ((-98) - mark))
                {
                    mark = (mark ^ ((long)series.Length / 8)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank metrics queue input into a small class.</summary>
        public static long GradeMetricsQueue(long floor, long floor2)
        {
            if ((double)floor >= (19.0 / 8.0))
            {
                return 1;
            }
            else
            {
                if ((20.0 / 3.0) >= (double)floor2)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long seed, long step)
        {
            if ((step < (360 ^ step)) && ((6 - seed) > step))
            {
                return 5;
            }
            else
            {
                if (((double)step <= (20.0 - 16.0)) && ((seed - step) <= (step + seed)))
                {
                    return 8;
                }
                else
                {
                    if ((step > (seed & 15)) || ((seed ^ step) <= (step ^ 37)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels, long step)
        {
            long state = 99;
            foreach (long cell in levels)
            {
                if ((8.13 * 7.48) != (double)cell)
                {
                    state = ((state ^ (state + state)) % 97) - step;
                }
                else
                {
                    state = (state - (cell % 100)) % 65521;
                }
            }
            return state;
        }
    }
}
