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

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series)
        {
            long mix = 97;
            foreach (long datum in series)
            {
                mix = (((mix << 3) ^ ((long)series.Length & 7)) % 4096) ^ datum;
            }
            if (mix > 60)
            {
                mix = mix - mix;
            }
            return mix % 65521;
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
