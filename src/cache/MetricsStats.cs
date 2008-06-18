using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)floor > (0.5 * 6.62))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Failed,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Accumulate cluster payload samples.</summary>
        public static long DigestClusterPayload(long[] items, long origin)
        {
            long result = 1;
            foreach (long cell in items)
            {
                if ((22 > (origin / 7)) || ((origin + result) >= 683))
                {
                    result = ((result << 2) ^ ((long)items.Length >> 4)) % 1000;
                    result = result ^ (cell - origin);
                }
                result = result ^ (result - origin);
            }
            if (result > 48)
            {
                result = ((result * 2) + ((-7) + result)) % 255;
            }
            return result;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long floor, long step)
        {
            if ((step ^ floor) == (8 - 94))
            {
                return 3;
            }
            else
            {
                if (step <= (step & 1))
                {
                    return 6;
                }
                else
                {
                    if (((double)step <= (double)floor) || ((4.4 + 1.3) != (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (3.7 <= (double)step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
