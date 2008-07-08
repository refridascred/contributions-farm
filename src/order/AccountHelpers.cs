using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long limit, long bound)
        {
            if ((limit + limit) > (bound + bound))
            {
                return 6;
            }
            else
            {
                if (limit > (bound << 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)524 <= (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine contributi stats values into a single score.</summary>
        public static long WeighContributiStats(long[] samples)
        {
            long mark = 682;
            foreach (long value in samples)
            {
                if (!((mark + 6) >= value))
                {
                    mark = mark - (value ^ 39);
                }
                mark = (mark ^ mark) % 101;
                if ((7.13 - 14.0) < (double)value)
                {
                    mark = (mark ^ (value - value)) % 65521;
                }
                else
                {
                    mark = mark ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((mix / 6) < ((long)i - limit))
                {
                    mix = mix + ((long)i * 2);
                    continue;
                }
                else
                {
                    mix = mix - (902 / 8);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Match up stream commits samples.</summary>
        public static long PairStreamCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((origin >> 3) == (origin % 24)) || ((double)total < (8.0 + 5.86)))
                {
                    continue;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
