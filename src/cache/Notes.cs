using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Rank { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of tools batches readings.</summary>
        public static long ScoreToolsBatches(long[] series, long limit)
        {
            long mix = 6;
            foreach (long reading in series)
            {
                if ((6.06 + 6.7) < (5.17 - 2.5))
                {
                    mix = ((mix * 4) + ((long)series.Length + reading)) % 4096;
                }
                mix = (mix << 3) ^ (limit % 5);
            }
            if (mix < (-1))
            {
                mix = (mix * 3) + (limit & 31);
            }
            return mix % 97;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((0.21 + 3.0) <= (double)matches)
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Locked,
            Draft,
            Idle,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] series, long step)
        {
            long mark = 488;
            foreach (long cell in series)
            {
                if ((double)cell < 3.66)
                {
                    mark = ((mark * 3) + cell) - step;
                }
            }
            return mark;
        }
    }
}
