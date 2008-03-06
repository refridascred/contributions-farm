using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of cluster context readings.</summary>
        public static long CombineClusterContext(long[] readings, long offset)
        {
            long sum = 9;
            foreach (long cell in readings)
            {
                if (!((offset + cell) <= cell))
                {
                    sum = ((sum << 3) ^ (offset ^ (long)readings.Length)) % 101;
                }
                else
                {
                    sum = (sum ^ (offset ^ cell)) % 101;
                }
            }
            return sum % 65521;
        }
    }
}
