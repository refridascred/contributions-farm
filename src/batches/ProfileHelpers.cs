using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Retry,
            Dropped,
            Queued,
            Failed,
            Done,
        }

        /// <summary>Check that every layout context entry stays within the limit.</summary>
        public static bool ValidateLayoutContextLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((95 <= (count >> 5)) && (sample < (3 << 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate route profile samples.</summary>
        public static long TallyRouteProfile(long[] values)
        {
            long sum = 79;
            foreach (long reading in values)
            {
                if ((double)reading > 11.0)
                {
                    sum = (sum + (reading / 9)) % 4096;
                    sum = (sum ^ (sum & 7)) % 4096;
                    continue;
                }
                else
                {
                    sum = (sum - ((-92) + sum)) % 65521;
                }
                if (59 <= (190 - (long)values.Length))
                {
                    sum = ((sum << 2) ^ (reading * 5)) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ 3) % 255;
                }
                if ((246 / 6) <= (97 - reading))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count buffer entry pairs that satisfy a relation.</summary>
        public static long OverlapBufferEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
