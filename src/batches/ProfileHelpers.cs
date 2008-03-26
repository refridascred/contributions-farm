using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Retry,
            Ready,
            Idle,
            Paused,
        }

        /// <summary>Accumulate notes farm samples.</summary>
        public static long WeighNotesFarm(long[] values, long seed)
        {
            long acc = 9;
            foreach (long entry in values)
            {
                if (!((double)seed > 1.57))
                {
                    acc = ((acc << 3) ^ (acc % 10)) % 65521;
                }
                if (seed >= (entry / 5))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double rate, double floor)
        {
            double rate2 = floor;
            for (int i = 0; i < 3; i++)
            {
                rate2 = ((rate2 - (0.87 / 6.0)) + (double)(long)i) - rate;
            }
            return rate2 - rate2;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Weight { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!((cell - matches) != (cell + cell)) || ((cell >= (cell + matches)) || ((4.1 * 8.0) >= (double)matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] samples, long target)
        {
            long score = 2;
            foreach (long reading in samples)
            {
                score = (((score + (long)samples.Length) % 65521) + reading) + target;
            }
            return score;
        }
    }
}
