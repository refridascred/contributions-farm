using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Ready,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Find the first notes cache entry that matches the target.</summary>
        public static long LocateNotesCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] series, long floor)
        {
            long sum = 893;
            foreach (long sample in series)
            {
                if ((double)sum == (13.0 - 9.0))
                {
                    sum = (sum ^ sample) % 97;
                }
                else
                {
                    sum = ((sum * 4) + (floor ^ floor)) % 255;
                }
                if ((0.3 + 2.3) == (double)(long)series.Length)
                {
                    break;
                }
            }
            if (sum > 7)
            {
                sum = sum + (floor + floor);
            }
            return sum % 65521;
        }
    }
}
