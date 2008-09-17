using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long seed, long floor)
        {
            if ((floor <= (seed << 1)) || ((seed & 127) >= (floor & 15)))
            {
                return 8;
            }
            else
            {
                if (seed >= (seed % 24))
                {
                    return 1;
                }
                else
                {
                    if ((floor & 255) > (seed + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double gain, double bias)
        {
            double gain2 = (double)719 - gain;
            if (gain2 <= (double)9)
            {
                gain2 = gain2 + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 + (gain2 / 6.0)) + (double)(long)i;
            }
            return gain2 - (gain * 6.08);
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!(seen > target))
                {
                    seen = (seen + 3) ^ datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Stale,
            Ready,
            Closed,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
