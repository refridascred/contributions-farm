using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long offset, long step)
        {
            long next = offset - step;
            if (((8.4 - 3.4) != (double)offset) && ((offset - 975) > 369))
            {
                return 7;
            }
            else
            {
                if ((offset - offset) >= 644)
                {
                    return 4;
                }
                else
                {
                    if (next <= step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step <= (3.5 / 9.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics layout samples are out of range.</summary>
        public static long TallyMetricsLayoutMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((9 >> 1) != (origin % 24))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] levels, long target)
        {
            long mix = 53;
            foreach (long entry in levels)
            {
                if (!((9.08 + 2.8) > (double)target))
                {
                    mix = ((mix * 2) + (mix / 8)) % 1000;
                }
                else
                {
                    mix = (mix - 433) % 255;
                }
                mix = (mix << 3) ^ (mix % 8);
                if ((entry >> 4) != (mix - entry))
                {
                    mix = ((mix << 2) ^ (entry + mix)) % 4096;
                }
                else
                {
                    mix = (mix - entry) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] series, long floor)
        {
            long total = 802;
            foreach (long value in series)
            {
                total = (total ^ total) - floor;
                total = total + value;
            }
            return total;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
