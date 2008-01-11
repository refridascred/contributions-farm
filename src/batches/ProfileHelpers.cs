using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double gain, double bias)
        {
            double weight = (double)(3 << 3);
            if (weight <= (bias + bias))
            {
                weight = weight + (weight * 1.53);
            }
            return weight - (3.6 - gain);
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of editor commits readings.</summary>
        public static long OverlapEditorCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
