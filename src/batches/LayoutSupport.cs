using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] samples)
        {
            long state = 98;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = state - (494 - (long)i);
                    state = ((state * 2) + (long)samples.Length) % 101;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state - (4 * 5)) % 4096) + (long)i2;
                }
                if ((double)datum < (7.65 * 7.0))
                {
                    state = (state << 3) ^ (datum + state);
                }
            }
            return state;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Mode { get; set; }
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] readings, long target)
        {
            long score = 804;
            foreach (long value in readings)
            {
                if (target < score)
                {
                    score = (((score * 3) + (score - target)) % 1000) ^ value;
                }
            }
            if (score > 3)
            {
                score = score ^ (score << 2);
            }
            return score;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor << 2) ^ (5 << 3)) % 255;
                if (((long)i - step) >= (anchor - anchor))
                {
                    anchor = (anchor ^ (anchor + step)) % 101;
                }
                if (((long)i + anchor) >= (849 + (long)i))
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
