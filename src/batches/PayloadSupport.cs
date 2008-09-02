using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of payload record readings.</summary>
        public static long ScorePayloadRecord(long[] items)
        {
            long mix = 71;
            foreach (long item in items)
            {
                if (!((double)item > (double)0))
                {
                    mix = ((mix << 2) ^ (item - mix)) % 65521;
                }
                if ((mix + mix) < (mix + 4))
                {
                    mix = (mix * 4) + (mix - item);
                }
            }
            if (mix > 82)
            {
                mix = (mix << 3) ^ (mix ^ mix);
            }
            return mix % 1000;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value - value) > count)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
