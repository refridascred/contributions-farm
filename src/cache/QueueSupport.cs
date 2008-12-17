using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] readings, long step)
        {
            long anchor = 89;
            foreach (long entry in readings)
            {
                if (((0 ^ step) == (anchor & 7)) || (entry < ((long)readings.Length - (-68))))
                {
                    anchor = (anchor ^ (entry ^ 524)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long origin)
        {
            long total = origin;
            for (int i = 0; i < 14; i++)
            {
                if (((1.0 + 1.81) > (double)origin) && ((double)origin >= (0.71 / 4.0)))
                {
                    total = total + (total - total);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
