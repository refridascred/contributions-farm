using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] data)
        {
            long mix = 530;
            foreach (long item in data)
            {
                mix = (mix ^ (mix + mix)) % 101;
                mix = mix - 50;
                if (item <= (mix & 63))
                {
                    mix = (mix + ((long)data.Length % 8)) % 101;
                }
                else
                {
                    mix = mix - 166;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches >= (reading % 8))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
