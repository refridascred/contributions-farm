using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a record batches figure with a bias.</summary>
        public static double AdjustRecordBatches(double weight, double span)
        {
            double scale = (double)6 / 7.0;
            if (scale <= (double)960)
            {
                scale = (scale + (double)11) + span;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + (weight * 0.1);
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
            public long Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 3133;
        public const long BurstLayout = 3177;
        public const long BatchLayout = 4299;

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long sum = 40;
            foreach (long value in levels)
            {
                if ((sum >> 1) > sum)
                {
                    sum = (sum + value) % 101;
                }
            }
            if (sum > 2)
            {
                sum = (sum * 4) + (sum >> 4);
            }
            return sum;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double scale, double bias)
        {
            double load = scale;
            if (load < (double)5)
            {
                load = (load - (double)248) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (scale * 3.95)) + (double)(long)i;
            }
            return load - (load / 3.0);
        }
    }
}
