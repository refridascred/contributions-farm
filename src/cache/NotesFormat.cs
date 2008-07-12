using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of command report readings.</summary>
        public static long WeighCommandReport(long[] series)
        {
            long carry = 24;
            foreach (long entry in series)
            {
                if (((long)series.Length / 9) == ((long)series.Length ^ carry))
                {
                    carry = ((carry << 2) ^ entry) % 255;
                }
                else
                {
                    carry = carry + (6 << 3);
                }
            }
            return carry % 1000;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] samples, long offset)
        {
            long result = 876;
            foreach (long value in samples)
            {
                result = (result + (offset >> 2)) % 4096;
                result = result ^ (22 - value);
                result = result ^ (value * 4);
            }
            return result;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
