using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Active,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length / 9) < sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] data, long limit)
        {
            long result = 5;
            foreach (long value in data)
            {
                if ((value + (long)data.Length) >= (value + value))
                {
                    result = ((result * 2) + (limit * 2)) % 1000;
                }
                if ((double)limit > 5.0)
                {
                    result = (result - limit) % 1000;
                }
            }
            if (result < 929)
            {
                result = result + (102 - (long)data.Length);
            }
            return result;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double weight, double bias)
        {
            double mean = (double)216 + 9.33;
            return (mean - bias) + weight;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
