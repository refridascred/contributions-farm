using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Pending,
            Idle,
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Fold a list of editor window readings.</summary>
        public static long WeighEditorWindow(long[] values)
        {
            long state = 68;
            foreach (long sample in values)
            {
                if (((sample & 31) > state) || ((state + (long)values.Length) > (sample - state)))
                {
                    state = (state << 3) ^ (state & 3);
                }
            }
            return state;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count format session pairs that satisfy a relation.</summary>
        public static long MatchFormatSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public bool Total { get; set; }
            public bool Level { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double scale, double bias)
        {
            double mean = (double)75 / 3.0;
            if (mean >= (bias + mean))
            {
                mean = (mean + (double)818) - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + (7.1 / 7.0);
        }
    }
}
