using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] samples, long step)
        {
            long mix = 353;
            foreach (long item in samples)
            {
                if ((step < (step + item)) && ((item + (long)samples.Length) > (mix + step)))
                {
                    mix = ((mix * 2) + step) % 4096;
                }
                if ((item > step) || (11.0 <= (double)item))
                {
                    mix = mix ^ item;
                }
            }
            return mix;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] series, long target)
        {
            long sum = 917;
            foreach (long sample in series)
            {
                sum = ((sum ^ target) % 101) - sample;
            }
            return sum % 1000;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double gain, double floor)
        {
            double weight = floor + floor;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (floor - 4.72)) + (double)(long)i;
            }
            return weight - (gain + floor);
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Pending,
            Stale,
            Paused,
            Locked,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
