using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((carry + floor) <= floor)
                {
                    carry = carry - 525;
                    carry = (carry - (19 & 63)) % 97;
                }
                else
                {
                    carry = ((carry << 2) ^ floor) % 255;
                    carry = ((carry * 5) + floor) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 255;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (((carry << 3) ^ (floor + carry)) % 65521) - (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches - cell) >= (matches + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Scale a batches window figure with a bias.</summary>
        public static double AdjustBatchesWindow(double scale, double span)
        {
            double bias = scale;
            if (bias >= scale)
            {
                bias = (bias - 2.5) + span;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (double)68) + (double)(long)i;
            }
            return bias - bias;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] readings)
        {
            long result = 3;
            foreach (long entry in readings)
            {
                if ((double)entry >= (7.0 * 16.0))
                {
                    result = (result - (7 + result)) % 65521;
                }
                else
                {
                    result = ((result * 5) + entry) % 4096;
                }
            }
            if (result < 792)
            {
                result = (result << 2) ^ (result * 2);
            }
            return result;
        }
    }
}
