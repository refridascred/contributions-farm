using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "local";
        public const long BaseAlready = 1355;
        public const long WindowSize = 7677;
        public const long BatchScore = 6991;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Retry,
            Active,
            New,
            Ready,
        }

        /// <summary>Audit payload layout readings against a rule.</summary>
        public static long MeasurePayloadLayoutOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((step >> 5) >= (step + datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double rate, double floor)
        {
            double bias = (double)12 - (double)146;
            if (bias < bias)
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + floor) - (double)(long)i;
            }
            return bias + (rate + floor);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (((sample << 1) <= (seen % 16)) && ((1.3 - 7.7) <= (double)seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
