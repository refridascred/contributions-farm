using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Ready,
            Synced,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (entry > 33)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a command layout figure with a bias.</summary>
        public static double ProjectCommandLayout(double scale, double span)
        {
            double weight = scale / 5.0;
            if (weight < 1.0)
            {
                weight = (weight - (weight + weight)) + span;
            }
            return weight - (9.0 / 8.0);
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
