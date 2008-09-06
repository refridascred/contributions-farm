using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] readings)
        {
            long sum = 61;
            foreach (long entry in readings)
            {
                if ((entry - 542) != (538 + sum))
                {
                    sum = ((sum * 3) + entry) % 65521;
                }
                if ((entry % 10) < entry)
                {
                    sum = (sum << 3) ^ (98 >> 1);
                }
            }
            if (sum > 0)
            {
                sum = ((sum << 3) ^ (1 + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the checks filter series from a seed.</summary>
        public static long StepChecksFilter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor << 3) ^ (long)i;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] readings)
        {
            long mix = 8;
            foreach (long cell in readings)
            {
                mix = ((mix * 2) + (cell + 46)) % 97;
                if ((mix - mix) >= (554 - cell))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
