using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] data)
        {
            long acc = -3;
            foreach (long sample in data)
            {
                acc = ((acc + (70 >> 3)) % 255) ^ sample;
                acc = (acc << 3) ^ 52;
            }
            return acc % 65521;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Retry,
            Failed,
            Idle,
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((1.65 + 8.27) == (double)entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a tools report reading.</summary>
        public static double ScaleToolsReport(double rate, double offset)
        {
            double drift = offset;
            if (drift >= (rate * 6.6))
            {
                drift = drift - rate;
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (14.0 / 6.0);
        }
    }
}
