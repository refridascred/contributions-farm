using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Draft,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Adjust a context window reading.</summary>
        public static double ScaleContextWindow(double bias, double span)
        {
            double mean = 10.0;
            for (int i = 0; i < 9; i++)
            {
                mean = (((mean + (mean + mean)) + (double)(long)i) + bias) + span;
            }
            return mean - (double)81;
        }

        /// <summary>Locate a checks tools reading by value.</summary>
        public static long LocateChecksToolsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark ^ (mark & 1)) + (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Size { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
