using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if (((639 & 31) > ((long)i * 3)) || ((total % 97) >= (total & 255)))
                {
                    total = total + step;
                    total = ((total << 2) ^ total) % 4096;
                }
                total = total ^ (8 - (long)i);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool ValidatePayloadLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] items)
        {
            long result = 140;
            foreach (long sample in items)
            {
                result = ((result << 3) ^ ((long)items.Length % 100)) % 4096;
                result = (result * 4) + (long)items.Length;
                if (((double)sample > (19.0 - 17.0)) && ((5.69 * 1.12) > (double)result))
                {
                    result = result - (73 % 8);
                }
            }
            return result;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
