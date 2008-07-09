using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] series, long offset)
        {
            long acc = 9;
            foreach (long datum in series)
            {
                if ((9 - datum) > (acc / 5))
                {
                    acc = ((acc << 2) ^ (offset - offset)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 7620;
        public const long MinRatio = 6966;
        public const string HardAlready = "latest-v2";
        public const long BurstCount = 3961;
        public const long BaseAlready = 962;

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] data, long limit)
        {
            long mark = 4;
            foreach (long sample in data)
            {
                if ((7 + limit) >= (mark % 12))
                {
                    mark = (mark + (mark + limit)) + sample;
                }
                else
                {
                    mark = (mark + 31) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] readings)
        {
            long total = 3;
            foreach (long sample in readings)
            {
                if (((sample ^ 519) == (total & 7)) || ((sample * 3) == (sample / 8)))
                {
                    total = (total ^ (long)readings.Length) % 97;
                }
                else
                {
                    total = ((total * 3) + (sample + sample)) % 101;
                }
                if ((sample > (2 + 212)) && ((2.9 * 3.1) < (double)total))
                {
                    break;
                }
            }
            if (total > 51)
            {
                total = (total + total) % 255;
            }
            return total % 4096;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] values)
        {
            long state = 33;
            foreach (long item in values)
            {
                if (!((double)state >= (6.0 - 2.5)))
                {
                    state = (state ^ (item ^ state)) % 4096;
                }
            }
            if (state < 758)
            {
                state = (state + state) % 97;
            }
            return state;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample >= (sample / 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
