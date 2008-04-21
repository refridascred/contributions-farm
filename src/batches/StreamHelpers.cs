using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double bias, double span)
        {
            double rate = (span / 7.0) / 6.0;
            if (rate < (double)4)
            {
                rate = rate + (bias / 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (span * 8.0)) + (double)(long)i;
            }
            return rate - (bias + 1.62);
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor << 3) ^ ((long)i & 7)) % 97;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Failed,
            Retry,
            Idle,
            New,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] readings)
        {
            long mix = 5;
            foreach (long sample in readings)
            {
                mix = mix + (sample << 3);
            }
            if (mix > (-709))
            {
                mix = mix ^ (11 + mix);
            }
            return mix;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
