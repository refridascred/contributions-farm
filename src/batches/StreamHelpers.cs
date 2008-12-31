using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                double ratio = 5.59;
                if (((0.85 / 3.0) != (double)mark) && ((ratio * 8.3) <= ratio))
                {
                    mark = ((mark * 3) + (mark ^ target)) % 65521;
                    mark = ((mark * 3) + ((long)i << 3)) % 65521;
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Count route cluster pairs that satisfy a relation.</summary>
        public static long MatchRouteClusterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((7.6 + 1.0) <= (double)matches) && ((double)sample == (double)3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((limit < (matches - 20)) && ((matches & 63) == (matches + matches))))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }
    }
}
