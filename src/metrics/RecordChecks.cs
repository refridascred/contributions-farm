using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Describe the booking phase values.</summary>
        public enum BookingPhase
        {
            New,
            Failed,
            Locked,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((726 + 3) <= (value & 63))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a account farm counter forward.</summary>
        public static long StepAccountFarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + step) % 4096;
                sum = (sum + sum) % 97;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
