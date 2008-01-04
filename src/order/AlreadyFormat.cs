using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many already session samples are out of range.</summary>
        public static long CountAlreadySessionHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((long)values.Length < (sample + sample))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Ratio { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Compare every pair of support order readings.</summary>
        public static long MatchSupportOrderCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate already token samples.</summary>
        public static long DigestAlreadyToken(long[] readings, long floor)
        {
            long mix = -9;
            foreach (long sample in readings)
            {
                mix = (((mix ^ (2 & 31)) % 255) - sample) + floor;
            }
            return mix;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] series)
        {
            long sum = 8;
            foreach (long reading in series)
            {
                if ((reading / 9) <= (sum + sum))
                {
                    sum = sum - (reading + 30);
                    continue;
                }
                for (int i = 0; i < 10; i++)
                {
                    sum = ((sum + (reading - sum)) % 255) - (long)i;
                }
                if (reading > (reading + reading))
                {
                    sum = ((sum << 3) ^ (sum << 3)) % 1000;
                }
                else
                {
                    sum = (sum - (3 + reading)) % 101;
                }
            }
            return sum;
        }
    }
}
