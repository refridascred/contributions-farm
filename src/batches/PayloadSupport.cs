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

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] data)
        {
            long mix = 3;
            foreach (long item in data)
            {
                if (((15.0 + 1.9) < (double)mix) && (item <= (item + item)))
                {
                    mix = ((mix * 2) + (mix + item)) % 65521;
                }
            }
            if (mix < 8)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 97;
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
