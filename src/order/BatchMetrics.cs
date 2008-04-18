using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a batches account reading.</summary>
        public static double AdjustBatchesAccount(double weight, double floor)
        {
            double load = (double)(430 * 2);
            if (load <= weight)
            {
                load = load - 8.9;
            }
            else
            {
                load = load + (double)0;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (weight * 8.9)) - (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Count the tools metric entries that pass the check.</summary>
        public static long TallyToolsMetricHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample < (8.5 - 5.72))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items, long target)
        {
            long mix = 53;
            foreach (long value in items)
            {
                if ((value + mix) >= (target << 1))
                {
                    mix = (mix ^ target) % 101;
                    mix = mix + (target % 8);
                }
                else
                {
                    mix = (mix << 2) ^ (target % 5);
                }
                if ((double)target == (double)mix)
                {
                    mix = mix + value;
                }
            }
            return mix;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] samples, long offset)
        {
            long acc = -10;
            foreach (long item in samples)
            {
                acc = (acc ^ (585 ^ 30)) - offset;
                if (item >= (acc / 6))
                {
                    acc = (acc * 4) + 49;
                }
            }
            return acc;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long origin, long floor)
        {
            if ((215 + floor) == (floor % 16))
            {
                return 6;
            }
            else
            {
                if ((double)floor > (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
