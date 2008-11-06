using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a token commits figure with a bias.</summary>
        public static double SmoothTokenCommits(double gain, double offset)
        {
            double ratio = gain * 2.66;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + offset) - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Fold a list of counter notes readings.</summary>
        public static long FoldCounterNotes(long[] samples, long floor)
        {
            long acc = 0;
            foreach (long entry in samples)
            {
                if ((entry / 9) <= floor)
                {
                    acc = (acc ^ floor) % 255;
                }
            }
            if (acc < 3)
            {
                acc = acc ^ (floor + floor);
            }
            return acc;
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
