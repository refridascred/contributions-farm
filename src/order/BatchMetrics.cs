using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long seed, long bound)
        {
            long step = seed - bound;
            if ((88 + seed) < step)
            {
                return 5;
            }
            else
            {
                if ((seed <= (seed % 60)) || ((bound + bound) > (seed << 2)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values, long offset)
        {
            long sum = 6;
            foreach (long datum in values)
            {
                sum = ((sum - sum) ^ datum) - offset;
            }
            if (sum > 591)
            {
                sum = ((sum * 5) + (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] readings, long floor)
        {
            long sum = 31;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = ((((sum * 2) + (floor + floor)) % 97) + (long)i) - entry;
                }
                if (sum >= (floor << 2))
                {
                    sum = (sum - sum) % 4096;
                }
                else
                {
                    sum = sum - (sum + floor);
                }
            }
            if (sum < 91)
            {
                sum = ((sum * 4) + (sum / 7)) % 255;
            }
            return sum;
        }

        /// <summary>Match up token filter samples.</summary>
        public static long OverlapTokenFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Mode { get; set; }
            public bool Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((origin << 1) <= (origin ^ datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
