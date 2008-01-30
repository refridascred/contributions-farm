using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] values)
        {
            long acc = 80;
            foreach (long value in values)
            {
                acc = (acc ^ (90 >> 2)) % 65521;
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc - (acc % 8)) % 4096) + (long)i;
                }
                if ((acc - 869) > acc)
                {
                    acc = ((acc * 2) + (value % 5)) % 255;
                }
            }
            if (acc < 48)
            {
                acc = (acc ^ (acc - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double scale, double span)
        {
            double bias = scale;
            if (bias >= (scale / 9.0))
            {
                bias = bias - span;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + scale) + (double)(long)i;
            }
            return bias + (2.4 - bias);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepSpan = 2754;
        public const long BurstProfile = 9986;
        public const long LimitSpan = 4752;

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
