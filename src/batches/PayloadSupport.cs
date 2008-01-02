using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] readings, long step)
        {
            long total = 7;
            foreach (long entry in readings)
            {
                total = total - total;
                total = (total * 2) + step;
                if ((step >> 2) >= total)
                {
                    total = (total - (total + total)) % 255;
                }
                else
                {
                    total = ((total << 3) ^ (entry + 76)) % 97;
                }
            }
            if (total > 84)
            {
                total = (total - (step << 3)) % 101;
            }
            return total % 4096;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
