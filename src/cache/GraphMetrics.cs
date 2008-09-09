using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of queue buffer readings.</summary>
        public static long OverlapQueueBufferCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double rate, double offset)
        {
            double drift = (offset * 5.8) + (rate + offset);
            if (drift > 12.0)
            {
                drift = drift + (rate * 3.6);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (drift / 7.0)) - (double)(long)i;
            }
            return drift + (8.0 + rate);
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MaxTimeout = "stable-1";
        public const long MaxChannel = 6461;
        public const long BaseChannel = 3963;
        public const double BatchChannel = 5.33;
    }
}
