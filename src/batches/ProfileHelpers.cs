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

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
