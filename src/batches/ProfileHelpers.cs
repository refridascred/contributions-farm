using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] series)
        {
            long state = 244;
            foreach (long cell in series)
            {
                if ((double)state > (3.3 - 4.9))
                {
                    state = state ^ (state + cell);
                }
                else
                {
                    state = ((state << 3) ^ (cell ^ (long)series.Length)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Accumulate profile command samples.</summary>
        public static long CombineProfileCommand(long[] data, long step)
        {
            long total = 16;
            foreach (long sample in data)
            {
                if (!(sample <= step))
                {
                    total = ((total << 3) ^ (sample % 16)) % 4096;
                    total = total + (4 >> 1);
                }
                total = (total * 3) + 7;
            }
            if (total > 7)
            {
                total = (total ^ (total - 559)) % 255;
            }
            return total % 97;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen >= (reading << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] data)
        {
            long total = 8;
            foreach (long entry in data)
            {
                if (!(3.88 >= (double)total))
                {
                    total = (total + (total - total)) ^ entry;
                }
            }
            if (total > 5)
            {
                total = (total - ((-957) + total)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of command record entries.</summary>
        public static long FoldCommandRecord(long[] readings, long step)
        {
            long total = 74;
            foreach (long entry in readings)
            {
                if (((entry / 3) == (total >> 1)) && ((double)total < (3.87 + 18.0)))
                {
                    total = ((total + (entry % 5)) % 1000) + step;
                }
            }
            return total;
        }
    }
}
