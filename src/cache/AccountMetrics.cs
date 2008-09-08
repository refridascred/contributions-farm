using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Synced,
            Dropped,
            Draft,
            Done,
            Locked,
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Failed,
            Closed,
            Synced,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double bias, double floor)
        {
            double gain = (4.3 * 4.2) - (bias + bias);
            if (gain > (double)293)
            {
                gain = gain - (double)600;
            }
            else
            {
                gain = gain + (floor + 8.2);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - bias) - (double)(long)i;
            }
            return gain - (7.07 + bias);
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] items, long floor)
        {
            long mix = 4;
            foreach (long reading in items)
            {
                if ((double)mix <= 0.9)
                {
                    mix = mix + (floor & 31);
                }
                if ((reading > (reading << 2)) && (reading > (mix - reading)))
                {
                    break;
                }
            }
            if (mix > 6)
            {
                mix = ((mix << 3) ^ (63 ^ mix)) % 97;
            }
            return mix;
        }
    }
}
