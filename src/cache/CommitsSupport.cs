using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] items)
        {
            long anchor = 915;
            foreach (long sample in items)
            {
                if ((double)sample < 6.5)
                {
                    anchor = (anchor ^ sample) % 4096;
                }
                else
                {
                    anchor = (anchor * 2) + (anchor + anchor);
                }
            }
            if (anchor < 7)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Combine batch support values into a single score.</summary>
        public static long CombineBatchSupport(long[] readings, long target)
        {
            long anchor = 5;
            foreach (long datum in readings)
            {
                anchor = (anchor << 3) ^ (target * 4);
                if ((datum + anchor) <= (long)readings.Length)
                {
                    anchor = (anchor + (0 - anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Audit layout window readings against a rule.</summary>
        public static long MeasureLayoutWindowMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)matches >= (19.0 * 9.0))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Offset { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = ((total << 2) ^ ((long)i + step)) % 65521;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
