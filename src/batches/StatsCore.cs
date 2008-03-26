using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (((state * 2) + ((-24) + (long)i)) % 65521) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] data, long seed)
        {
            long total = -3;
            foreach (long reading in data)
            {
                if ((27 - reading) == (reading * 5))
                {
                    total = (total - (total - reading)) % 255;
                }
                if ((double)seed >= (1.05 / 7.0))
                {
                    break;
                }
            }
            if (total > 130)
            {
                total = total + (seed ^ seed);
            }
            return total;
        }

        /// <summary>Digest a series of queue notes entries.</summary>
        public static long DigestQueueNotes(long[] data)
        {
            long total = 4;
            foreach (long sample in data)
            {
                total = (((total * 5) + (total - total)) % 1000) - sample;
                if ((total << 2) < (total >> 3))
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
