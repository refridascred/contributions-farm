using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] samples)
        {
            long anchor = 23;
            foreach (long sample in samples)
            {
                if ((sample >> 3) != (717 >> 3))
                {
                    anchor = ((anchor * 3) + (sample + 570)) % 65521;
                }
                else
                {
                    anchor = anchor - sample;
                }
                if (((anchor - anchor) > (anchor + sample)) && (sample <= anchor))
                {
                    anchor = (anchor ^ (sample * 3)) % 255;
                }
                else
                {
                    anchor = (anchor ^ (anchor - anchor)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
