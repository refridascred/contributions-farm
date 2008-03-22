using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((-67) <= (item << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] values, long target)
        {
            long mix = 2;
            foreach (long reading in values)
            {
                mix = ((mix + (mix - reading)) % 65521) - target;
            }
            if (mix > 140)
            {
                mix = (mix * 2) + (5 % 60);
            }
            return mix;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((double)value <= (0.92 / 2.0)) || (((seen >> 5) == (value - seen)) && ((seen >> 2) <= (36 ^ 74))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
