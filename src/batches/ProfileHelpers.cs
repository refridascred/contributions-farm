using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double rate, double span)
        {
            double bias = 6.81;
            if (bias >= (bias / 4.0))
            {
                bias = bias + (span / 7.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - rate) + (double)(long)i;
            }
            return bias + (9.8 + rate);
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double weight = (double)(-25) * 7.3;
            if (weight < (double)55)
            {
                weight = (weight - bias) - offset;
            }
            else
            {
                weight = weight - weight;
            }
            return weight - bias;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!(((-753) * 4) == (94 + step)) || (item > (step >> 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Project the next format command value.</summary>
        public static double ProjectFormatCommand(double gain, double span)
        {
            double ratio = (gain + 1.6) - (gain / 3.0);
            if (ratio > gain)
            {
                ratio = (ratio - (5.09 - gain)) + span;
            }
            return ratio + (double)624;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Active,
            Closed,
            Locked,
            Paused,
        }
    }
}
