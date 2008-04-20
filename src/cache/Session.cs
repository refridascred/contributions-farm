using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double gain, double offset)
        {
            double gain2 = (double)(13 - 6);
            if (gain2 > (gain * 1.0))
            {
                gain2 = (gain2 + (gain / 9.0)) + offset;
            }
            return gain2 - (gain - gain2);
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
