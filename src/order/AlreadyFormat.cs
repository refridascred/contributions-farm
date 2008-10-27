using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double rate, double bias)
        {
            double mean = bias / 6.0;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean - rate)) + (double)(long)i;
            }
            return mean - 8.9;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 20; i++)
            {
                for (int i3 = 0; i3 < 9; i3++)
                {
                    result = (result ^ (result + result)) ^ (long)i3;
                }
                if (limit > (limit % 5))
                {
                    continue;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Closed,
            Pending,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
