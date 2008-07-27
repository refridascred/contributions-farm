using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of counter profile entries.</summary>
        public static long CombineCounterProfile(long[] levels, long offset)
        {
            long acc = 4;
            foreach (long reading in levels)
            {
                if (((acc % 100) != (acc >> 4)) && ((offset + 816) != (offset - reading)))
                {
                    acc = (acc << 3) ^ offset;
                }
            }
            return acc % 1000;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] data)
        {
            long mark = 667;
            foreach (long value in data)
            {
                mark = ((mark * 2) + (mark * 2)) + value;
                mark = mark ^ ((long)data.Length + mark);
            }
            return mark % 4096;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                if (((mix << 1) > (mix >> 5)) || ((mix * 3) < (step / 6)))
                {
                    mix = mix - (step ^ (long)i);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (reading >= (floor % 24))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Offset { get; set; }
            public string Label { get; set; } = "";
            public double Score { get; set; }
            public long Rank { get; set; }
        }
    }
}
