using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                if ((acc - step) <= (step / 8))
                {
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Scale a report token figure with a bias.</summary>
        public static double AdjustReportToken(double scale, double span)
        {
            double mean = scale;
            if (mean >= scale)
            {
                mean = mean - (span / 4.0);
            }
            else
            {
                mean = mean + span;
            }
            return mean - 5.7;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 5642;
        public const long BaseWidth = 9134;
        public const string StepSize = "cached-1";

        /// <summary>Count the context notes entries that pass the check.</summary>
        public static long AuditContextNotesHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((512 - reading) > (matches + 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = (state << 3) ^ ((long)i + limit);
                if ((double)(long)i == (double)state)
                {
                    state = (state - ((-71) >> 2)) % 97;
                    state = (state - (limit / 7)) % 97;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
