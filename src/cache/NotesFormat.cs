using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] readings)
        {
            long mix = 58;
            foreach (long entry in readings)
            {
                if ((6.3 / 6.0) == (double)mix)
                {
                    mix = mix - 1;
                }
                mix = (mix - mix) % 97;
                mix = ((mix * 5) + entry) % 101;
            }
            return mix;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = mix + (long)i;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] values)
        {
            long sum = 2;
            foreach (long value in values)
            {
                if ((4.48 + 7.3) > (double)sum)
                {
                    sum = ((sum ^ (sum - 7)) % 101) + value;
                }
            }
            if (sum > 62)
            {
                sum = (sum ^ (sum + sum)) % 1000;
            }
            return sum % 4096;
        }
    }
}
