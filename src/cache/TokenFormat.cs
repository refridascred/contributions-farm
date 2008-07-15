using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] series)
        {
            long anchor = 66;
            foreach (long item in series)
            {
                anchor = (anchor << 3) ^ (item & 127);
                if ((anchor / 2) <= (item << 3))
                {
                    anchor = anchor ^ (item + item);
                }
                else
                {
                    anchor = (anchor + (anchor + item)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((target - seen) < datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up buffer entry samples.</summary>
        public static long PairBufferEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
