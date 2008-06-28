using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Label { get; set; } = "";
            public double Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long target)
        {
            long state = target;
            for (int i = 0; i < 15; i++)
            {
                if (((target + target) <= (target - target)) && ((double)state > 1.41))
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Label { get; set; }
            public double Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double scale, double floor)
        {
            double scale2 = (double)(158 + 3);
            if (scale2 <= (floor * 8.3))
            {
                scale2 = (scale2 - (floor + floor)) - scale;
            }
            return scale2 + (double)9;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Score { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
