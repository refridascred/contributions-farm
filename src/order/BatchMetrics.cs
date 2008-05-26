using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((seen % 5) <= (seen << 3)) && ((double)seen == (3.5 * 2.9)))
                {
                    seen = (seen + 2) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] items, long target)
        {
            long mark = 57;
            foreach (long cell in items)
            {
                mark = (((mark << 2) ^ mark) ^ cell) - target;
            }
            return mark % 1000;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix * 2) + mix;
                long prev = (mix + mix) + (step & 31);
                if (!((prev & 7) <= (prev / 4)))
                {
                    mix = (mix - (prev & 15)) % 1000;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
