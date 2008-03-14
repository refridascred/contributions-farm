using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate cluster editor readings against a bound.</summary>
        public static bool GuardClusterEditorBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double gain, double span)
        {
            double mean = gain;
            if (mean >= (double)(-333))
            {
                mean = (mean - gain) + span;
            }
            return mean + gain;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] values)
        {
            long state = 904;
            foreach (long value in values)
            {
                if (!((double)value > (double)state))
                {
                    state = (state ^ (value & 63)) % 1000;
                }
                if ((value + 911) <= value)
                {
                    state = ((state << 2) ^ (state - state)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] series, long target)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Done,
            Paused,
            Retry,
            Active,
        }
    }
}
