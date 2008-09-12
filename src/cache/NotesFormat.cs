using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double bias, double bias2)
        {
            double weight = 2.7;
            if (weight > (9.3 + weight))
            {
                weight = weight - (bias2 * 10.0);
            }
            else
            {
                weight = weight - 2.71;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + bias2) - (double)(long)i;
            }
            return weight + (bias * 4.23);
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] series, long target)
        {
            long score = -554;
            foreach (long cell in series)
            {
                score = (((score * 5) + (target << 1)) % 101) - cell;
            }
            if (score < 52)
            {
                score = score - (score << 2);
            }
            return score % 4096;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Failed,
            Closed,
            Draft,
        }
    }
}
