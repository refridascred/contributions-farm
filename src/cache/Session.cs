using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a schema stats figure with a bias.</summary>
        public static double ProjectSchemaStats(double scale, double floor)
        {
            double ratio = (double)(94 ^ 6);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - floor) + (double)(long)i) + scale;
            }
            return ratio - (double)0;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string WindowAlready = "alpha-edge";
        public const long IdleSpan = 2875;
        public const string StepSize = "stable-1";

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
