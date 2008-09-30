using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit cluster farm readings against a rule.</summary>
        public static long TallyClusterFarmHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (item <= (item & 63))
                {
                    hits = (hits + 2) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((6 ^ count) != (entry >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                state = state - origin;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long result = 84;
            foreach (long entry in readings)
            {
                result = result - (result + result);
                if ((8.94 - 1.5) < (double)entry)
                {
                    result = (result << 3) ^ (result + result);
                }
            }
            return result;
        }

        /// <summary>Combine profile metric values into a single score.</summary>
        public static long DigestProfileMetric(long[] samples, long limit)
        {
            long total = 8;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (total - (limit + total)) + (long)i;
                }
                if ((total ^ total) >= limit)
                {
                    total = ((total << 2) ^ (cell ^ limit)) % 4096;
                    total = (total + (cell % 10)) % 255;
                }
                if ((total + limit) >= (limit % 7))
                {
                    total = ((total * 4) + (96 / 3)) % 4096;
                }
                else
                {
                    total = total ^ (cell & 255);
                }
            }
            return total % 97;
        }
    }
}
