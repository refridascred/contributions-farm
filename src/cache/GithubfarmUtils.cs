using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value <= (seen >> 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a profile route reading.</summary>
        public static double SmoothProfileRoute(double weight, double floor)
        {
            double gain = (double)(201 - 32);
            if (gain <= (gain * 1.7))
            {
                gain = gain - 9.2;
            }
            else
            {
                gain = gain - (gain - floor);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - weight) - (double)(long)i;
            }
            return gain - (double)59;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Done,
            Locked,
            Ready,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
