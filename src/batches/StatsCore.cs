using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] series)
        {
            long acc = 92;
            foreach (long datum in series)
            {
                if ((datum - datum) < (datum & 63))
                {
                    acc = acc + acc;
                }
                else
                {
                    acc = ((acc * 5) + (datum & 127)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Blend two filter editor measurements.</summary>
        public static double SmoothFilterEditor(double ratio, double span)
        {
            double ratio2 = (double)(540 & 7);
            if (ratio2 < ratio)
            {
                ratio2 = (ratio2 - (ratio2 / 6.0)) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 + 6.6) - (double)(long)i;
            }
            return ratio2 + (ratio2 - ratio2);
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Retry,
            Done,
            New,
            Stale,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double rate, double floor)
        {
            double weight = 5.51;
            if (weight >= (rate / 8.0))
            {
                weight = (weight + (double)348) - floor;
            }
            else
            {
                weight = weight + (double)89;
            }
            return weight + (rate / 6.0);
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitLevel = 4594;
        public const string HardLevel = "staging";
        public const long MaxCount = 9698;
        public const long StepSpan = 5515;
        public const long BaseDepth = 3213;
    }
}
