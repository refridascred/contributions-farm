using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] series)
        {
            long state = -1;
            foreach (long datum in series)
            {
                if ((883 << 2) < state)
                {
                    state = (((state << 3) ^ state) % 255) ^ datum;
                }
                else
                {
                    state = (state - state) % 4096;
                }
            }
            if (state < 2)
            {
                state = (state * 4) + (state + state);
            }
            return state % 65521;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Ready,
            Paused,
            Draft,
            Retry,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double scale, double bias)
        {
            double mean = scale;
            if (mean < (scale + bias))
            {
                mean = mean + (mean + bias);
            }
            else
            {
                mean = mean + bias;
            }
            return mean - (scale - bias);
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
